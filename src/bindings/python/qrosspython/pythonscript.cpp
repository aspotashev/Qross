/***************************************************************************
 * pythonscript.cpp
 * This file is part of the KDE project
 * copyright (C)2004-2006 by Sebastian Sauer (mail@dipe.org)
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 * You should have received a copy of the GNU Library General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
 * Boston, MA 02110-1301, USA.
 ***************************************************************************/

#include "pythonscript.h"
#include "pythonmodule.h"
#include "pythoninterpreter.h"
#include "pythonextension.h"
#include "pythonvariant.h"
#include <qross/core/action.h>

//TODO move that functionality to PythonExtension!
#include <QMetaObject>
#include <QMetaMethod>
#include "pythonfunction.h"

using namespace Qross;

namespace Qross {

    /// \internal
    class PythonScriptPrivate
    {
        public:

            /**
            * The \a Py::Module instance this \a PythonScript
            * has as local context.
            */
            Py::Module* m_module;

            /**
            * The PyCodeObject object representing the
            * compiled python code. Internaly we first
            * compile the python code and later execute
            * it.
            */
            Py::Object* m_code;

            /**
            * List of QObject instances that should be
            * auto connected on execution.
            * \see ChildrenInterface::AutoConnectSignals
            */
            QList< QPointer<QObject> > m_autoconnect;

            /**
            * The \a PythonFunction instances this \a Script
            * is the owner of. For example the m_autoconnect
            * list does produce such \a PythonFunction
            * instances and we try to take care of removing
            * them if not needed any longer.
            */
            QList< PythonFunction* > m_functions;

            PythonScriptPrivate() : m_module(0), m_code(0) {}
    };

}

PythonScript::PythonScript(Qross::Interpreter* interpreter, Qross::Action* action)
    : Qross::Script(interpreter, action)
    , d(new PythonScriptPrivate())
{
    #ifdef QROSS_PYTHON_SCRIPT_CTOR_DEBUG
        qrossdebug("PythonScript::Constructor.");
    #endif
}

PythonScript::~PythonScript()
{
    #ifdef QROSS_PYTHON_SCRIPT_DTOR_DEBUG
        qrossdebug("PythonScript::Destructor.");
    #endif
    qDeleteAll( d->m_functions );

    if( Py_IsInitialized() && d->m_module )
        d->m_module->getDict().clear();

    delete d->m_module; d->m_module = 0;
    delete d->m_code; d->m_code = 0;
    delete d;
}

Py::Dict PythonScript::moduleDict() const
{
    Q_ASSERT(d->m_module);
    return d->m_module->getDict();
}

bool PythonScript::initialize()
{
    #ifdef QROSS_PYTHON_SCRIPT_INIT_DEBUG
        qrossdebug( QString("PythonScript::initialize") );
    #endif

    finalize(); // finalize before initialize

    try {
        if(action()->code().isNull()) {
            setError( QString("Invalid scripting code for script '%1'").arg(action()->objectName()) );
            return false;
        }
        if(action()->objectName().isNull()) {
            setError( QString("Name for the script is invalid!") );
            return false;
        }

        Q_ASSERT( ! action()->objectName().isNull() );
        QFileInfo fi( action()->objectName() );
        QString n = QFileInfo(fi.absolutePath(), fi.baseName()).absoluteFilePath();
        QByteArray filename = n.isNull() ? action()->objectName().toLatin1() : n.toLatin1();
        filename.replace('.','_'); // points are used as module-delimiters
        char* name = filename.data();

        { // Each Action uses an own module as scope.
            //PyObject* pymod = PyModule_New(name);
            PyObject* pymod = PyImport_AddModule(name);
            Q_ASSERT(pymod);
            //PyModule_AddStringConstant(pymod, "__file__", filename.data());

            //PyObject* m = PyImport_AddModule(name);
            d->m_module = new Py::Module(pymod, false); //don't take over ownership
            if(! d->m_module) {
                setError( QString("Failed to initialize local module context for script '%1'").arg(action()->objectName()) );
                return false;
            }

            /*
            // Register in module dict to allow such codes like: from whatever import mymodule
            PyObject* importdict = PyImport_GetModuleDict();
            if(! importdict) {
                //finalize();
                setError( QString("Failed to fetch the import dictornary for script '%1'").arg(action()->objectName()) );
                return false;
            }
            PyDict_SetItemString(importdict, name, pymod);
            */
        }

        #ifdef QROSS_PYTHON_SCRIPT_INIT_DEBUG
            qrossdebug( QString("PythonScript::initialize() module='%1' refcount='%2'").arg(d->m_module->as_string().c_str()).arg(d->m_module->reference_count()) );
        #endif

        { // Add additional stuff to the modules dictonary of this PythonScript.
            Py::Dict moduledict = d->m_module->getDict();

            // Add the builtin and main module.
            PythonModule* pythonmodule = ((PythonInterpreter*)interpreter())->mainModule();
            moduledict["__builtins__"] = pythonmodule->getDict()["__builtins__"];
            moduledict["__main__"] = pythonmodule->module();
//moduledict["__dict__"] = Py::Dict();
//moduledict["__all__"] = Py::Dict();

            // Add our Action instance as "self" to the modules dictonary.
            moduledict[ "self" ] = Py::asObject(new PythonExtension(action()));

            // Add the QObject instances to the modules dictonary.
            QHashIterator< QString, QObject* > aoit( action()->objects() );
            while(aoit.hasNext()) {
                aoit.next();
                PythonExtension* extension = new PythonExtension( aoit.value() );
                moduledict[ aoit.key().toLatin1().data() ] = Py::asObject(extension);

                ChildrenInterface::Options options = action()->objectOption( aoit.key() );
                if( options & ChildrenInterface::AutoConnectSignals )
                    d->m_autoconnect.append( aoit.value() );
            }

            // Set up the import hook
            PyObject* pyimporthook = PyRun_String("__main__._Importer(self)", Py_file_input, moduledict.ptr(), moduledict.ptr());
            if(! pyimporthook) throw Py::Exception(); // throw exception
            Py_XDECREF(pyimporthook); // free the reference.

            // Add the script's directory to the sys.path
            if( ! action()->currentPath().isNull() ) {
                //FIXME: should we remove the dir again after the job is done?
                QString s = QString("import sys\nsys.path.append(r'%1')").arg( action()->currentPath() );
                QByteArray ba = s.toLatin1();
                PyObject* pyrunsyspath = PyRun_String(ba.data(), Py_file_input, moduledict.ptr(), moduledict.ptr());
                if(! pyrunsyspath) throw Py::Exception(); // throw exception
                Py_XDECREF(pyrunsyspath); // free the reference.
            }

            // Walk through the global list of published QObject instances.
            QHashIterator< QString, QObject* > moit( Manager::self().objects() );
            while(moit.hasNext()) {
                moit.next();
                ChildrenInterface::Options options = Manager::self().objectOption( moit.key() );
                if( options & ChildrenInterface::AutoConnectSignals )
                    d->m_autoconnect.append( moit.value() );
            }

            /*
            // Prepare the local context.
            QString s =
                //"import sys\n"
                //"if self.has(\"stdout\"):\n"
                //"  self.stdout = Redirect( self.get(\"stdout\") )\n"
                //"if self.has(\"stderr\"):\n"
                //"  self.stderr = Redirect( self.get(\"stderr\") )\n"
                ;
            Py::Dict mainmoduledict = ((PythonInterpreter*)interpreter())->mainModule()->getDict();
            PyObject* pyrun = PyRun_String((char*)s.toLatin1().data(), Py_file_input, mainmoduledict.ptr(), moduledict.ptr());
            if(! pyrun)
                throw Py::Exception(); // throw exception
            Py_XDECREF(pyrun); // free the reference.
            */
        }


        #ifdef QROSS_PYTHON_SCRIPT_INIT_DEBUG
            qrossdebug( QString("PythonScript::initialize() name=%1").arg(action()->objectName()) );
        #endif

        { // Compile the python script code. It will be later on request executed. That way we cache the compiled code.
            //PyCompilerFlags cf;
            //cf.cf_flags |= PyCF_SOURCE_IS_UTF8;
            PyObject* code = Py_CompileString( //Py_CompileStringFlags(
                (char*) action()->code().data(),
                (char*) action()->objectName().toLatin1().data(),
                Py_file_input
                //, &cf
            );
            if(! code)
                throw Py::Exception();
            d->m_code = new Py::Object(code, true);
        }
    }
    catch(Py::Exception& e) {
        Py::Object err = Py::value(e);
        if(err.ptr() == Py_None) err = Py::type(e); // e.g. string-exceptions have there errormessage in the type-object
        QStringList trace;
        int lineno;
        PythonInterpreter::extractException(trace, lineno);
        setError(err.as_string().c_str(), trace.join("\n"), lineno);
        PyErr_Print(); //e.clear();
        return false;
    }

    return true;
}

void PythonScript::finalize()
{
    #ifdef QROSS_PYTHON_SCRIPT_FINALIZE_DEBUG
        qrossdebug( QString("PythonScript::finalize() module=%1").arg(d->m_module ? d->m_module->as_string().c_str() : "NULL") );
    #endif

    PyErr_Clear();
    clearError();
    d->m_autoconnect.clear();
    qDeleteAll( d->m_functions );
    d->m_functions.clear();
    if( d->m_module )
        d->m_module->getDict().clear();
    delete d->m_module; d->m_module = 0;
    delete d->m_code; d->m_code = 0;
}

void PythonScript::execute()
{
    #ifdef QROSS_PYTHON_SCRIPT_EXEC_DEBUG
        qrossdebug( QString("PythonScript::execute") );
    #endif

    if( hadError() ) {
        #ifdef QROSS_PYTHON_SCRIPT_EXEC_DEBUG
            qrosswarning( QString("PythonScript::execute Abort cause of prev error: %1\n%2").arg(errorMessage()).arg(errorTrace()) );
        #endif
        Py::AttributeError(errorMessage());
        return;
    }

    PyErr_Clear();
    //clearError(); // clear previous errors.

    if(! d->m_module) { // initialize if not already done before.
        if(! initialize())
            return;
    }

    Q_ASSERT( d->m_code && d->m_code->ptr() );

    try {

        // the main module dictonary.
        Py::Dict mainmoduledict = ((PythonInterpreter*)interpreter())->mainModule()->getDict();
        // the local context dictonary.
        Py::Dict moduledict( d->m_module->getDict().ptr() );

        /*
        // Initialize context before execution.
        QString s =
            "import sys, os\n"
            //"__import__ = __main__.__import__\n"
            //"if self.has(\"stdout\"):\n"
            //"  sys.stdout = Redirect( self.get(\"stdout\") )\n"
            //"if self.has(\"stderr\"):\n"
            //"  sys.stderr = Redirect( self.get(\"stderr\") )\n"
            ;

        PyObject* pyrun = PyRun_String(
            s.toLatin1().data(),
            Py_file_input,
            mainmoduledict.ptr(),
            moduledict.ptr()
        );
        if(! pyrun)
            throw Py::Exception(); // throw exception
        Py_XDECREF(pyrun); // free the reference.
        */

        // Acquire interpreter lock
        PyGILState_STATE gilstate = PyGILState_Ensure();

        // Evaluate the already compiled code.
        PyObject* pyresult = PyEval_EvalCode(
            (PyCodeObject*)d->m_code->ptr(),
            moduledict.ptr(), //mainmoduledict.ptr(),
            moduledict.ptr()
        );

        // Free interpreter lock
        PyGILState_Release(gilstate);

        if(! pyresult)
            throw Py::Exception();
        Py::Object result(pyresult, true);
        if(PyErr_Occurred())
            throw Py::Exception();

        // while valgrind complains, it's ok to shape references to code here
        //Q_ASSERT( d->m_code->reference_count() == 1 );

        #ifdef QROSS_PYTHON_SCRIPT_EXEC_DEBUG
            qrossdebug( QString("PythonScript::execute result=%1").arg(result.as_string().c_str()) );
        #endif

        // try to autoconnect
        foreach(QObject* obj, d->m_autoconnect) {
            if( ! obj ) continue;
            const QMetaObject* metaobject = obj->metaObject();
            const int count = metaobject->methodCount();
            for(int i = 0; i < count; ++i) {
                QMetaMethod metamethod = metaobject->method(i);
                if( metamethod.methodType() == QMetaMethod::Signal ) {
                    const QString signature = metamethod.signature();
                    const QByteArray name = signature.left(signature.indexOf('(')).toLatin1();

                    PyObject* pyfunc = PyDict_GetItemString(moduledict.ptr(), name.constData());
                    if( pyfunc ) {
                        Py::Callable callable(pyfunc);
                        PythonFunction* function = new PythonFunction(obj, metamethod.signature(), callable);
                        QByteArray sendersignal = QString("2%1").arg(signature).toLatin1();
                        QByteArray receiverslot = QString("1%1").arg(signature).toLatin1();
                        if( QObject::connect(obj, sendersignal, function, receiverslot) ) {
                            #ifdef QROSS_PYTHON_SCRIPT_AUTOCONNECT_DEBUG
                                qrossdebug( QString("PythonScript::execute connect object=%1 signal=%2 with pythonfunction=%3").arg(obj->objectName()).arg(signature).arg(name.constData()) );
                            #endif
                            d->m_functions.append(function);
                        }
                        else {
                            #ifdef QROSS_PYTHON_SCRIPT_AUTOCONNECT_DEBUG
                                qrossdebug( QString("PythonScript::execute failed to connect object=%1 signal=%2 with pythonfunction=%3").arg(obj->objectName()).arg(signature).arg(name.constData()) );
                            #endif
                            delete function;
                        }
                    }
                }
            }
        }

        //return PythonExtension::toObject(result);
    }
    catch(Py::Exception& e) {
        Py::Object err = Py::value(e);
        if(err.ptr() == Py_None) err = Py::type(e); // e.g. string-exceptions have there errormessage in the type-object
        QStringList trace;
        int lineno;
        PythonInterpreter::extractException(trace, lineno);
        setError(err.as_string().c_str(), trace.join("\n"), lineno);
        PyErr_Print(); //e.clear();
    }
}

QStringList PythonScript::functionNames()
{
    if(! d->m_module) { // initialize if not already done before.
        if(! initialize())
            return QStringList();
    }
    QStringList functions;
    Py::Dict moduledict = d->m_module->getDict();
    for(Py::Dict::iterator it = moduledict.begin(); it != moduledict.end(); ++it) {
        Py::Dict::value_type vt(*it);
        //if(PyClass_Check( vt.second.ptr() )) continue; // ignore classes since they are callable too
        if(vt.second.isCallable())
            functions.append( vt.first.as_string().c_str() );
    }
    return functions;
}

QVariant PythonScript::callFunction(const QString& name, const QVariantList& args)
{
    //TODO do we need to acquire interpreter lock here?

    #ifdef QROSS_PYTHON_SCRIPT_CALLFUNC_DEBUG
        QString s;
        foreach(QVariant v, args)
            s += v.toString() + ',';
        qrossdebug( QString("PythonScript::callFunction() name=%1 args=[%2]").arg(name).arg(s) );
    #endif

    if( hadError() ) {
        #ifdef QROSS_PYTHON_SCRIPT_CALLFUNC_DEBUG
            qrosswarning( QString("PythonScript::callFunction() Abort cause of prev error: %1\n%2").arg(errorMessage()).arg(errorTrace()) );
        #endif
        Py::AttributeError( errorMessage() );
        return QVariant();
    }

    PyErr_Clear();
    //clearError(); // clear previous errors.

    if(! d->m_module) { // initialize if not already done before.
        if(! initialize())
            return QVariant();
        execute(); // execute if not already done before.
        if( hadError() )
            return QVariant();
    }

    try {
        Py::Dict moduledict = d->m_module->getDict();

        // Try to determinate the function we like to execute.
        PyObject* func = PyDict_GetItemString(moduledict.ptr(), name.toLatin1().data());
        if(! func) {
            Py::AttributeError( ::QString("No such function '%1'.").arg(name).toLatin1().constData() );
            //setError( QString("No such function '%1'.").arg(name) );
            //finalize();
            return QVariant();
        }

        // Check if the object is really a function and callable.
        Py::Callable funcobject(func, false);
        if(! funcobject.isCallable()) {
            Py::AttributeError( ::QString("Function '%1' is not callable.").arg(name).toLatin1().constData() );
            //setError( QString("Function '%1' is not callable.").arg(name) );
            //finalize();
            return QVariant();
        }

        // Finally call the function.
        Py::Object pyresult = funcobject.apply( PythonType<QVariantList,Py::Tuple>::toPyObject(args) );
        QVariant result = PythonType<QVariant>::toVariant(pyresult);
        #ifdef QROSS_PYTHON_SCRIPT_CALLFUNC_DEBUG
            qrossdebug( QString("PythonScript::callFunction() result=%1 variant.toString=%2 variant.typeName=%3").arg(pyresult.as_string().c_str()).arg(result.toString()).arg(result.typeName()) );
        #endif
        //finalize();
        return result;
    }
    catch(Py::Exception& e) {
        #ifdef QROSS_PYTHON_SCRIPT_CALLFUNC_DEBUG
            qrosswarning( QString("PythonScript::callFunction() Exception: %1").arg(Py::value(e).as_string().c_str()) );
        #endif
        Py::Object err = Py::value(e);
        if(err.ptr() == Py_None) err = Py::type(e); // e.g. string-exceptions have there errormessage in the type-object
        QStringList trace;
        int lineno;
        PythonInterpreter::extractException(trace, lineno);
        setError(err.as_string().c_str(), trace.join("\n"), lineno);
        PyErr_Print(); //e.clear();
        //finalize();
    }

    return QVariant();
}

QVariant PythonScript::evaluate(const QByteArray& code)
{
    if(! d->m_module) { // initialize if not already done before.
        if(! initialize())
            return QVariant();
    }

    Py::Dict moduledict( d->m_module->getDict().ptr() );

    // Acquire interpreter lock
    PyGILState_STATE gilstate = PyGILState_Ensure();
    // Evaluate the code
    PyObject* r = PyRun_String(code.data(), Py_eval_input, moduledict.ptr(), moduledict.ptr());
    // Free interpreter lock
    PyGILState_Release(gilstate);

    Py::Object pyresult(r, true /* owner */);
    return PythonType<QVariant>::toVariant(pyresult);
}

#if 0
const QStringList& PythonScript::getClassNames()
{
    if(! d->m_module) if(! initialize()) return false; //TODO catch exception
    return d->m_classes;
}
Qross::Object::Ptr PythonScript::classInstance(const QString& name)
{
    if(hadException()) return Qross::Object::Ptr(0); // abort if we had an unresolved exception.
    if(! d->m_module) {
        setException( new Qross::Exception(QString("Script not initialized.")) );
        return Qross::Object::Ptr(0);
    }
    try {
        Py::Dict moduledict = d->m_module->getDict();
        // Try to determinate the class.
        PyObject* pyclass = PyDict_GetItemString(moduledict.ptr(), name.toLatin1().data());
        if( (! d->m_classes.contains(name)) || (! pyclass) ) throw Qross::Exception::Ptr( new Qross::Exception(QString("No such class '%1'.").arg(name)) );
        PyObject *pyobj = PyInstance_New(pyclass, 0, 0);//aclarg, 0);
        if(! pyobj) throw Qross::Exception::Ptr( new Qross::Exception(QString("Failed to create instance of class '%1'.").arg(name)) );
        Py::Object classobject(pyobj, true);
        #ifdef QROSS_PYTHON_SCRIPT_CLASSINSTANCE_DEBUG
            qrossdebug( QString("PythonScript::classInstance() inst='%1'").arg(classobject.as_string().c_str()) );
        #endif
        return Qross::Object::Ptr( PythonExtension::toObject(classobject) );
    }
    catch(Py::Exception& e) {
        QString err = Py::value(e).as_string().c_str();
        e.clear(); // exception is handled. clear it now.
        setException( new Qross::Exception(err) );
    }
    catch(Qross::Exception::Ptr e) {
        setException(e.data());
    }
    return Qross::Object::Ptr(0); // return nothing if exception got thrown.
}
#endif

