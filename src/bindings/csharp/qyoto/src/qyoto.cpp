/***************************************************************************
                          qyoto.cpp  -  description
                             -------------------
    begin                : Wed Jun 16 2004
    copyright            : (C) 2004 by Richard Dale
    email                : Richard_Dale@tipitina.demon.co.uk
 ***************************************************************************/

/***************************************************************************
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU Lesser General Public License as        *
 *   published by the Free Software Foundation; either version 2 of the    *
 *   License, or (at your option) any later version.                       *
 *                                                                         *
 ***************************************************************************/

#ifndef _GNU_SOURCE
#define _GNU_SOURCE
#endif
#include <stdio.h>
#include <stdlib.h>

#include <QAbstractItemDelegate>
#include <QAbstractItemView>
#include <QAbstractProxyModel>
#include <QAbstractTextDocumentLayout>
#include <QMetaMethod>
#include <QModelIndex>
#include <QtCore/qbytearray.h>
#include <QtCore/qhash.h>
#include <QtCore/qobject.h>
#include <QtCore/qregexp.h>
#include <QtCore/qstring.h>
#include <QtCore/qstringlist.h>
#include <QtDBus/QDBusReply>
#include <QtGui/qapplication.h>

#undef DEBUG
#ifndef __USE_POSIX
#define __USE_POSIX
#endif
#ifndef __USE_XOPEN
#define __USE_XOPEN
#endif
#ifdef _BOOL
#define HAS_BOOL
#endif                                                          

#ifndef QT_VERSION_STR
#define QT_VERSION_STR "Unknown"
#endif

#include "marshall.h"
#include "qyoto.h"
#include "smokeqyoto.h"
#include "smoke.h"

#include "qyotosmokebinding.h"
#include "methodcall.h"
#include "emitsignal.h"
#include "invokeslot.h"

#define QYOTO_VERSION "0.0.1"
// #define DEBUG

#include <qtcore_smoke.h>
#include <qtgui_smoke.h>
#include <qtxml_smoke.h>
#include <qtsql_smoke.h>
#include <qtopengl_smoke.h>
#include <qtnetwork_smoke.h>
#include <qtsvg_smoke.h>
#include <qtdbus_smoke.h>

extern bool qRegisterResourceData(int, const unsigned char *, const unsigned char *, const unsigned char *);
extern bool qUnregisterResourceData(int, const unsigned char *, const unsigned char *, const unsigned char *);

extern Q_DECL_IMPORT TypeHandler Qyoto_handlers[];
extern void install_handlers(TypeHandler *);

extern bool IsContainedInstanceQt(smokeqyoto_object *o);
extern const char * qyoto_resolve_classname_qt(smokeqyoto_object * o);

extern "C" {

static bool 
qyoto_event_notify(void **data)
{
	// don't do anything if the application has already terminated
	if (application_terminated) return false;
	QObject *receiver = reinterpret_cast<QObject*>(data[0]);
	QEvent *event = reinterpret_cast<QEvent*>(data[1]);

	// If a child has been given a parent then make a global ref to it, to prevent
	// garbage collection. If a parent has been removed, then remove to global ref
	// to the child also.
	if (event->type() == QEvent::ChildAdded || event->type() == QEvent::ChildRemoved) {
		QChildEvent *e = static_cast<QChildEvent *>(event);
		void * childObj = (*GetInstance)(e->child(), true);
		if (childObj != 0) {
			smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(childObj);
			// Maybe add a check whether the childObj is still a QObject here
			if (e->added()) {
				(*AddGlobalRef)(childObj, e->child());
				o->allocated = false;  // we don't need to care about deleting stuff anymore
			} else {
				(*RemoveGlobalRef)(childObj, e->child());
				o->allocated = true;  // now we need to care about deletion again
			}

			(*FreeGCHandle)(childObj);
		}
	} else if (event->type() == QEvent::Show || event->type() == QEvent::Hide) {
		if (!receiver->isWidgetType() || receiver->parent() != 0)
			return false;

		void *obj = (*GetInstance)(receiver, true);
		if (!obj)
			return false;

		if (event->type() == QEvent::Show) {
			(*AddGlobalRef)(obj, receiver);    // Keep top-level widgets alive as long as they're visible.
		} else {
			(*RemoveGlobalRef)(obj, receiver);    // Make them eligible for collection as soon as they're hidden (and if there are no more references to them, obviously).
		}

		(*FreeGCHandle)(obj);
	}

	return false;
}

Q_DECL_EXPORT void
SetDebug(int channel) 
{
	do_debug = channel;
}

Q_DECL_EXPORT int
DebugChannel() 
{
	return do_debug;
}

Q_DECL_EXPORT Smoke::ModuleIndex 
FindMethodId(char * classname, char * mungedname, char * signature) 
{
	static Smoke::ModuleIndex negativeIndex(0, -1);
#ifdef DEBUG
	printf("FindMethodId(classname: %s mungedname: %s signature: %s)\n", classname, mungedname, signature);
	fflush(stdout);
#endif

	Smoke::ModuleIndex meth = qtcore_Smoke->findMethod(classname, mungedname);
#ifdef DEBUG
	if (do_debug & qtdb_calls) printf("DAMNIT on %s::%s => %d\n", classname, mungedname, meth.index);
#endif
	if (meth.index == 0) {
		foreach (Smoke *smoke, qyoto_modules.keys()) {
			meth = smoke->findMethod("QGlobalSpace", mungedname);
			if (meth.index)
				break;
		}
#ifdef DEBUG
		if (do_debug & qtdb_calls) printf("DAMNIT on QGlobalSpace::%s => %d\n", mungedname, meth.index);
#endif
	}
	
    if (meth.index == 0) {
    	return negativeIndex;
		// empty list
	} else if(meth.index > 0) {
		Smoke::Index i = meth.smoke->methodMaps[meth.index].method;
		if (i == 0) {		// shouldn't happen
	    	return negativeIndex;
		} else if (i > 0) {	// single match
	    	Smoke::Method &methodRef = meth.smoke->methods[i];
			if ((methodRef.flags & Smoke::mf_internal) == 0) {
				Smoke::ModuleIndex ret(meth.smoke, i);
				return ret;
			}
		} else {		// multiple match
	    	int ambiguousId = -i;		// turn into ambiguousMethodList index
			while (meth.smoke->ambiguousMethodList[ambiguousId] != 0) {
				Smoke::Method &methodRef = meth.smoke->methods[meth.smoke->ambiguousMethodList[ambiguousId]];
				if ((methodRef.flags & Smoke::mf_internal) == 0) {
static QByteArray * currentSignature = 0;
					if (currentSignature == 0) {
						currentSignature = new QByteArray("");
					}

					signature = strchr(signature, '(');
					*currentSignature = "(";
		
					for (int i = 0; i < methodRef.numArgs; i++) {
						if (i != 0) *currentSignature += ", ";
						*currentSignature += meth.smoke->types[meth.smoke->argumentList[methodRef.args + i]].name;
					}
		
					*currentSignature += ")";
					if (methodRef.flags & Smoke::mf_const) {
						*currentSignature += " const";
					}
		
#ifdef DEBUG
					printf(	"\t\tIn FindAmbiguousMethodId(%d, %s) => %d (%s)\n", 
							ambiguousId,
							signature,
							meth.smoke->ambiguousMethodList[ambiguousId],
							(const char *) *currentSignature );
					fflush(stdout);
#endif
		
					if (*currentSignature == signature) {
						Smoke::ModuleIndex ret(meth.smoke,  meth.smoke->ambiguousMethodList[ambiguousId]);
						return ret;
					}
				}
				ambiguousId++;
			}
		}
	}
	
	return negativeIndex;
}

static QMetaObject* get_meta_object(const char* classname) {
    Smoke::ModuleIndex classId = Smoke::findClass(classname);
    Smoke::ModuleIndex nameId = classId.smoke->idMethodName("staticMetaObject");
    Smoke::ModuleIndex meth = classId.smoke->findMethod(classId, nameId);
    if (meth.index <= 0) {
        // Should never happen..
    }

    Smoke::Method &methodId = meth.smoke->methods[meth.smoke->methodMaps[meth.index].method];
    Smoke::ClassFn fn = meth.smoke->classes[methodId.classId].classFn;
    Smoke::StackItem i[1];
    (*fn)(methodId.method, 0, i);
    return (QMetaObject*) i[0].s_voidp;
}

/* Adapted from the internal function qt_qFindChildren() in qobject.cpp */
Q_DECL_EXPORT void
cs_qFindChildren_helper(const QObject *parent, const QString &name, const QRegExp *re,
                         const QMetaObject &mo, QList<void*> *list)
{
	if (!parent || !list)
		return;
	
	const QObjectList &children = parent->children();
	QObject *obj;
	
	for (int i = 0; i < children.size(); ++i) {
		obj = children.at(i);
		if (mo.cast(obj)) {
			if (re) {
				if (re->indexIn(obj->objectName()) != -1)
					list->append((*GetInstance)(obj, true));
			} else {
				if (name.isNull() || obj->objectName() == name)
					list->append((*GetInstance)(obj, true));
			}
		}
		cs_qFindChildren_helper(obj, name, re, mo, list);
	}
}

/* Should mimic Qt4's QObject::findChildren method with this syntax:
     obj.findChildren(Qt::Widget, "Optional Widget Name")
*/
Q_DECL_EXPORT void
FindQObjectChildren(void* parent, const char *childClassName, void* childMetaObject, void* regexp, char* childName, FromIntPtr addFn)
{
	smokeqyoto_object *o;
	o = (smokeqyoto_object*) (*GetSmokeObject)(parent);
	QObject* p = (QObject*) o->ptr;

	QMetaObject *mo = 0;
	if (childMetaObject != 0) {
		o = (smokeqyoto_object*) (*GetSmokeObject)(childMetaObject);
		mo = (QMetaObject*) o->ptr;
		(*FreeGCHandle)(childMetaObject);
	} else {
		mo = get_meta_object(childClassName);
	}

	QRegExp* re = 0;
	if (regexp) {
		o = (smokeqyoto_object*) (*GetSmokeObject)(regexp);
		re = (QRegExp*) o->ptr;
		(*FreeGCHandle)(regexp);
	}
	
	QList<void*> *list = new QList<void*>();
	
	cs_qFindChildren_helper(p, QString::fromUtf8(childName), re, *mo, list);
	
	for(int i = 0; i < list->size(); ++i) {
		(*addFn)(list->at(i));
	}
	(*FreeGCHandle)(parent);
}

/* Adapted from the internal function qt_qFindChild() in qobject.cpp */
Q_DECL_EXPORT void *
cs_qFindChild_helper(QObject* parent, const QString &name, const QMetaObject &mo)
{
	const QObjectList &children = parent->children();
	QObject* obj;
	void* monoObject;
	
	int i;
	for (i = 0; i < children.size(); ++i) {
		obj = children.at(i);
		if (mo.cast(obj) && (name.isNull() || obj->objectName() == name)) {
			monoObject = (*GetInstance)(obj, true);
			return monoObject;
		}
	}
	for (i = 0; i < children.size(); ++i) {
		monoObject = cs_qFindChild_helper(children.at(i), name, mo);
		if (monoObject)
			return monoObject;
	}
	return 0;
}

Q_DECL_EXPORT void *
FindQObjectChild(void* parent, const char* childClassName, void* childMetaObject, char * childName)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(parent);
	QObject *p = (QObject*) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QObject", true).index);
	(*FreeGCHandle)(parent);

	QMetaObject *mo = 0;
	if (childMetaObject != 0) {
		o = (smokeqyoto_object*) (*GetSmokeObject)(childMetaObject);
		mo = (QMetaObject*) o->ptr;
		(*FreeGCHandle)(childMetaObject);
	} else {
		mo = get_meta_object(childClassName);
	}

	return cs_qFindChild_helper(p, childName, *mo);
}

Q_DECL_EXPORT void*
qyoto_qt_metacast(void* obj, char* target)
{
	smokeqyoto_object* o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	(*FreeGCHandle)(obj);
	QObject* qobj = (QObject*) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QObject").index);
	void* ret = qobj->qt_metacast(target);
	if (!ret) return 0;
	void* instance = (*GetInstance)(ret, true);
	if (instance) {
#ifdef DEBUG
		printf("qyoto_qt_metacast: found instance, returning 0x%8.8x\n", instance);
#endif
		return instance;
	}
	Smoke::ModuleIndex mi = Smoke::classMap[target];
	smokeqyoto_object* to = alloc_smokeqyoto_object(false, mi.smoke, mi.index, ret);
	instance = (*CreateInstance)(qyoto_resolve_classname(to), to);
	mapPointer(instance, to, to->classId, 0);
#ifdef DEBUG
	printf("qyoto_qt_metacast: created new instance of type %s (%p)\n", target, to->ptr);
#endif
	return instance;
}

Q_DECL_EXPORT void
qyoto_qdbus_reply_fill(void *msg, void *error, void *variant)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(msg);
	QDBusMessage *dbusmsg = (QDBusMessage*) o->ptr;
	(*FreeGCHandle)(msg);
	
	o = (smokeqyoto_object*) (*GetSmokeObject)(error);
	QDBusError *dbuserror = (QDBusError*) o->ptr;
	(*FreeGCHandle)(error);
	
	o = (smokeqyoto_object*) (*GetSmokeObject)(variant);
	QVariant *v = (QVariant*) o->ptr;
	(*FreeGCHandle)(variant);
	
	qDBusReplyFill(*dbusmsg, *dbuserror, *v);
}

Q_DECL_EXPORT void *
QVariantValue(char * typeName, void * variant)
{
#ifdef DEBUG
	printf("ENTER QVariantValue(typeName: %s variant: 0x%8.8x)\n", typeName, variant);
#endif
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(variant);
	(*FreeGCHandle)(variant);
	QVariant *v = (QVariant*) o->ptr;
	int type = QMetaType::type(typeName);
	void *value = 0;
	if (v->canConvert((QVariant::Type) type)) {
		v->convert((QVariant::Type) type);
		value = QMetaType::construct(type, v->constData());
	} else {
		value = QMetaType::construct(type, 0);
	}
	
	if (qstrcmp(typeName, "QDBusVariant") == 0) {
		Smoke::ModuleIndex id = o->smoke->findClass("QVariant");
		smokeqyoto_object  * vo = alloc_smokeqyoto_object(true, id.smoke, id.index, value);
		return (*CreateInstance)("Qyoto.QDBusVariant", vo);
	}
	
	Smoke::ModuleIndex id = o->smoke->findClass(typeName);
	if (!id.smoke) return value;  // class not found in smoke, so it's probably just a GCHandle
	smokeqyoto_object  * vo = alloc_smokeqyoto_object(true, id.smoke, id.index, value);
	return (*CreateInstance)(qyoto_resolve_classname(vo), vo);
}

Q_DECL_EXPORT void *
QVariantFromValue(int type, void * value)
{
#ifdef DEBUG
	printf("ENTER QVariantFromValue(type: %d value: 0x%8.8x)\n", type, value);
#endif
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(value);
	if (o) (*FreeGCHandle)(value);
	QVariant * v = new QVariant(type, o? o->ptr : value);
	Smoke::ModuleIndex id = qtcore_Smoke->findClass("QVariant");
	smokeqyoto_object  * vo = alloc_smokeqyoto_object(true, id.smoke, id.index, (void *) v);
	return (*CreateInstance)("Qyoto.QVariant", vo);
}

Q_DECL_EXPORT void
DestroyObject(const char *className, void *ptr)
{
	if (!ptr) return;
	QByteArray klassName(className);
	QByteArray dtor = "~" + klassName;
	QByteArray sig = dtor + "()";
	Smoke::ModuleIndex mi = FindMethodId(klassName.data(), dtor.data(), sig.data());
	if (!mi.smoke) {
		printf("can't destroy %p, missing method: %s\n", ptr, sig.constData());
		return;
	}
	const Smoke::Method &method = mi.smoke->methods[mi.index];
	const Smoke::Class &klass = mi.smoke->classes[method.classId];
	(*klass.classFn)(method.method, ptr, 0);
}

Q_DECL_EXPORT void*
CreateObject(char *className, void *other)
{
	QByteArray klassName(className);
	Smoke::ModuleIndex mi;
	Smoke::StackItem stack[2];
	
	if (other) {
		QByteArray ctor = klassName + "#";
		QByteArray signature = klassName + "(const " + klassName + "&)";
		mi = FindMethodId(className, ctor.data(), signature.data());
		if (!mi.smoke) {
			printf("can't create copy of %p, missing method: %s\n", other, signature.data());
			return 0;
		}
		stack[1].s_voidp = other;
	} else {
		QByteArray signature = klassName + "()";
		mi = FindMethodId(className, klassName.data(), signature.data());
		if (!mi.smoke) {
			printf("can't create object, missing method: %s\n", signature.data());
			return 0;
		}
	}
	
	const Smoke::Method &method = mi.smoke->methods[mi.index];
	const Smoke::Class &klass = mi.smoke->classes[method.classId];
	(*klass.classFn)(method.method, 0, stack);
	// set the binding
	stack[1].s_voidp = qyoto_modules[mi.smoke].binding;
	(*klass.classFn)(0, stack[0].s_voidp, stack);
	return stack[0].s_voidp;
}

Q_DECL_EXPORT int
QMetaTypeRegisterType(const char *name, QMetaType::Destructor destructor, QMetaType::Constructor constructor)
{
	return QMetaType::registerType(name, destructor, constructor);
}

Q_DECL_EXPORT void *
ModelIndexInternalPointer(void *obj)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	QModelIndex *modelIndex = (QModelIndex*) o->ptr;
	void *ptr = modelIndex->internalPointer();
	(*FreeGCHandle)(obj);
	return ptr;
}

Q_DECL_EXPORT void *
AbstractItemModelCreateIndex(void* obj, int row, int column, void *ptr)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	
	Smoke::Index method = FindMethodId((char*) "QAbstractItemModel", (char*) "createIndex$$$", (char*) "(int, int, void*) const").index;
	if (method == -1) {
		return 0;
	}
	Smoke::Method &methodId = o->smoke->methods[method];
	Smoke::ClassFn fn = o->smoke->classes[methodId.classId].classFn;
	Smoke::StackItem i[4];
	i[1].s_int = row;
	i[2].s_int = column;
	i[3].s_voidp = ptr;
	(*fn)(methodId.method, o->ptr, i);
	
	if (i[0].s_voidp == 0) {
		return 0;
	}
	
	int id = o->smoke->idClass("QModelIndex").index;
	smokeqyoto_object *ret = alloc_smokeqyoto_object(true, o->smoke, id, i[0].s_voidp);
	(*FreeGCHandle)(obj);
	return (*CreateInstance)("Qyoto.QModelIndex", ret);
}

Q_DECL_EXPORT void *
QAbstractItemModelParent(void* obj, void * modelIndex)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(modelIndex);
	QModelIndex ix = ((QAbstractItemModel*) o->ptr)->parent(*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(modelIndex);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(	true, 
														o->smoke, 
														o->smoke->idClass("QModelIndex").index, 
														new QModelIndex(ix) );
	return (*CreateInstance)("Qyoto.QModelIndex", ret);
}

Q_DECL_EXPORT int
QAbstractItemModelColumnCount(void* obj, void * modelIndex)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(modelIndex);
	int result = ((QAbstractItemModel*) o->ptr)->columnCount(*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(modelIndex);
	return result;
}

Q_DECL_EXPORT int
QAbstractItemModelRowCount(void* obj, void * modelIndex)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(modelIndex);
	int result = ((QAbstractItemModel*) o->ptr)->rowCount(*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(modelIndex);
	return result;
}

Q_DECL_EXPORT void*
QAbstractItemModelData(void* obj, void * modelIndex, int role)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(modelIndex);
	QVariant result = ((QAbstractItemModel*) o->ptr)->data(*(((QModelIndex*) i->ptr)), role);
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(modelIndex);
	smokeqyoto_object * ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QVariant").index, &result);
	return (*CreateInstance)("Qyoto.QVariant", ret);
}

Q_DECL_EXPORT void*
QAbstractItemModelIndex(void* obj, int row, int column, void * modelIndex)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(modelIndex);
	QModelIndex result = ((QAbstractItemModel*) o->ptr)->index(row, column, *(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(modelIndex);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QModelIndex").index, &result);
	return (*CreateInstance)("Qyoto.QModelIndex", ret);
}

Q_DECL_EXPORT void*
QAbstractProxyModelMapFromSource(void* obj, void* sourceIndex)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(sourceIndex);
	QModelIndex result = ((QAbstractProxyModel*) o->ptr)->mapFromSource(*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(sourceIndex);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QModelIndex").index, &result);
	return (*CreateInstance)("Qyoto.QModelIndex", ret);
}

Q_DECL_EXPORT void*
QAbstractProxyModelMapToSource(void* obj, void* proxyIndex)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(proxyIndex);
	QModelIndex result = ((QAbstractProxyModel*) o->ptr)->mapToSource(*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(proxyIndex);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QModelIndex").index, &result);
	return (*CreateInstance)("Qyoto.QModelIndex", ret);
}

Q_DECL_EXPORT void
QAbstractItemDelegatePaint(void* obj, void* painter, void* option, void* index)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *p = (smokeqyoto_object*) (*GetSmokeObject)(painter);
	smokeqyoto_object *opt = (smokeqyoto_object*) (*GetSmokeObject)(option);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(index);
	((QAbstractItemDelegate*) o->ptr)->paint((QPainter*) p->ptr, *((QStyleOptionViewItem*) opt->ptr), 
						*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(painter);
	(*FreeGCHandle)(option);
	(*FreeGCHandle)(index);
}

Q_DECL_EXPORT void*
QAbstractItemDelegateSizeHint(void* obj, void* option, void* index)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *opt = (smokeqyoto_object*) (*GetSmokeObject)(option);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(index);
	QSize result = ((QAbstractItemDelegate*) o->ptr)->sizeHint(*((QStyleOptionViewItem*) opt->ptr), 
									*(((QModelIndex*) i->ptr)));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(option);
	(*FreeGCHandle)(index);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QSize").index, &result);
	return (*CreateInstance)("Qyoto.QSize", ret);
}

Q_DECL_EXPORT void*
QAbstractItemViewIndexAt(void* obj, void* point)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *p = (smokeqyoto_object*) (*GetSmokeObject)(point);
	QModelIndex result = ((QAbstractItemView*) o->ptr)->indexAt(*((QPoint*) p->ptr));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(point);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QModelIndex").index, &result);
	return (*CreateInstance)("Qyoto.QModelIndex", ret);
}

Q_DECL_EXPORT void
QAbstractItemViewScrollTo(void* obj, void* index, int hint)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(index);
	((QAbstractItemView*) o->ptr)->scrollTo(*((QModelIndex*) i->ptr), (QAbstractItemView::ScrollHint) hint);
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(index);
}

Q_DECL_EXPORT void*
QAbstractItemViewVisualRect(void* obj, void* index)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *i = (smokeqyoto_object*) (*GetSmokeObject)(index);
	QRect result = ((QAbstractItemView*) o->ptr)->visualRect(*((QModelIndex*) i->ptr));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(index);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QRect").index, &result);
	return (*CreateInstance)("Qyoto.QRect", ret);
}

Q_DECL_EXPORT void*
QAbstractTextDocumentLayoutBlockBoundingRect(void* obj, void* block)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *b = (smokeqyoto_object*) (*GetSmokeObject)(block);
	QRectF result = ((QAbstractTextDocumentLayout*) o->ptr)->blockBoundingRect(*((QTextBlock*) b->ptr));
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(block);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QRectF").index, &result);
	return (*CreateInstance)("Qyoto.QRectF", ret);
}

Q_DECL_EXPORT void*
QAbstractTextDocumentLayoutDocumentSize(void* obj)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	QSizeF result = ((QAbstractTextDocumentLayout*) o->ptr)->documentSize();
	(*FreeGCHandle)(obj);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QSizeF").index, &result);
	return (*CreateInstance)("Qyoto.QSizeF", ret);
}

Q_DECL_EXPORT void*
QAbstractTextDocumentLayoutFrameBoundingRect(void* obj, void* frame)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *f = (smokeqyoto_object*) (*GetSmokeObject)(frame);
	QRectF result = ((QAbstractTextDocumentLayout*) o->ptr)->frameBoundingRect((QTextFrame*) f->ptr);
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(frame);
	smokeqyoto_object *ret = alloc_smokeqyoto_object(false, o->smoke, o->smoke->idClass("QRectF").index, &result);
	return (*CreateInstance)("Qyoto.QRectF", ret);
}

Q_DECL_EXPORT int
QAbstractTextDocumentLayoutHitTest(void* obj, void* point, int accuracy)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	smokeqyoto_object *p = (smokeqyoto_object*) (*GetSmokeObject)(point);
	int result = ((QAbstractTextDocumentLayout*) o->ptr)->hitTest(*((QPointF*) p->ptr), (Qt::HitTestAccuracy) accuracy);
	(*FreeGCHandle)(obj);
	(*FreeGCHandle)(point);
	return result;
}

Q_DECL_EXPORT int
QAbstractTextDocumentLayoutPageCount(void* obj)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	int result = ((QAbstractTextDocumentLayout*) o->ptr)->pageCount();
	(*FreeGCHandle)(obj);
	return result;
}

Q_DECL_EXPORT bool QyotoRegisterResourceData(int flag, const unsigned char * s, const unsigned char *n, const unsigned char *d)
{
	return qRegisterResourceData(flag, s, n, d);
}

Q_DECL_EXPORT bool QyotoUnregisterResourceData(int flag, const unsigned char * s, const unsigned char *n, const unsigned char *d)
{
	return qUnregisterResourceData(flag, s, n, d);
}

Q_DECL_EXPORT void 
InstallFreeGCHandle(FromIntPtr callback)
{
	FreeGCHandle = callback;
}

Q_DECL_EXPORT void 
InstallGetSmokeObject(GetIntPtr callback)
{
	GetSmokeObject = callback;
}

Q_DECL_EXPORT void 
InstallSetSmokeObject(SetIntPtr callback)
{
	SetSmokeObject = callback;
}

Q_DECL_EXPORT void 
InstallAddGlobalRef(SetIntPtr callback)
{
	AddGlobalRef = callback;
}

Q_DECL_EXPORT void 
InstallRemoveGlobalRef(SetIntPtr callback)
{
	RemoveGlobalRef = callback;
}

Q_DECL_EXPORT void 
InstallMapPointer(MapPointerFn callback)
{
	MapPointer = callback;
}

Q_DECL_EXPORT void 
InstallUnmapPointer(FromIntPtr callback)
{
	UnmapPointer = callback;
}

Q_DECL_EXPORT void 
InstallGetInstance(GetInstanceFn callback)
{
	GetInstance = callback;
}

Q_DECL_EXPORT void
InstallOverridenMethod(OverridenMethodFn callback)
{
	OverridenMethod = callback;
}

Q_DECL_EXPORT void 
InstallInvokeMethod(InvokeMethodFn callback)
{
	InvokeMethod = callback;
}

Q_DECL_EXPORT void 
InstallCreateInstance(CreateInstanceFn callback)
{
	CreateInstance = callback;
}

Q_DECL_EXPORT void
InstallInvokeCustomSlot(InvokeCustomSlotFn callback)
{
	InvokeCustomSlot = callback;
}

Q_DECL_EXPORT void
InstallGetProperty(OverridenMethodFn callback)
{
	GetProperty = callback;
}

Q_DECL_EXPORT void
InstallSetProperty(SetPropertyFn callback)
{
	SetProperty = callback;
}

Q_DECL_EXPORT void
SetApplicationTerminated()
{
	application_terminated = true;
}

Q_DECL_EXPORT int
SizeOfLong()
{
	return sizeof(long);
}

/* 
	Based on this function from QtCore/qhash.h:

	inline uint qHash(ulong key)
	{
		if (sizeof(ulong) > sizeof(uint)) {
			return uint((key >> (8 * sizeof(uint) - 1)) ^ key);
		} else {
			return uint(key);
		}
	}
*/
Q_DECL_EXPORT int 
QyotoHash(void * obj)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	(*FreeGCHandle)(obj);

	if (sizeof(void*) > sizeof(int)) {
		qint64 key = (qint64) o->ptr;
		return (int) ((key >> (8 * sizeof(int) - 1)) ^ key);
	} else {
		return (int) (qint64) o->ptr;
	}
}

Q_DECL_EXPORT void
CallSmokeMethod(Smoke * smoke, int methodId, void * obj, Smoke::StackItem * sp, int items)
{
	Smoke::Method meth = smoke->methods[methodId];
	const char *methname = smoke->methodNames[meth.name];
#ifdef DEBUG
	printf("ENTER CallSmokeMethod(methodId: %d methodName: %s target: 0x%8.8x class: %s items: %d module: %s)\n", methodId, methname, obj, smoke->className(meth.classId), items, smoke->moduleName());
#endif

	// C# operator methods must be static, and so some C++ instance methods with one argument
	// are mapped onto C# static methods with two arguments in the Qyoto classes. So look for
	// examples of these and changes the args passed to the QyotoMethodCall() constructor. Note
	// that 'operator>>' and 'operator<<' methods in C# must have a second arg of type int,
	// and so they are mapped onto the instance methods Read() and Write() in C#.
	if (	meth.numArgs == 1
			&& qstrncmp("operator", methname, sizeof("operator")) == 0
			&& qstrncmp("operator<<", methname, sizeof("operator<<")) != 0
			&& qstrncmp("operator>>", methname, sizeof("operator>>")) != 0 )
	{ // instance operator
		obj = sp[1].s_class;
		sp[1] = sp[2];
		items = 1;
	} else if (meth.numArgs == 0 && (qstrcmp("operator++", methname) == 0 || qstrcmp("operator--", methname) == 0)) {
		// instance operator++ / operator-- method that maps onto a static C# operator method
		obj = sp[1].s_class;
		items = 0;
	}

	Qyoto::MethodCall c(smoke, methodId, obj, sp, items);
	c.next();

#ifdef DEBUG
	printf("LEAVE CallSmokeMethod()\n");
#endif

	return;
}

Q_DECL_EXPORT bool
SignalEmit(char * signature, char * type, void * obj, Smoke::StackItem * sp, int items)
{
	smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
	QObject *qobj = (QObject*)o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QObject").index);

	if (qobj->signalsBlocked()) {
		(*FreeGCHandle)(obj);
		return false;
	}

	QString sig(signature);
	QString replyType(type);

	const QMetaObject* meta = qobj->metaObject();
	int i;
	for (i = 0; i < meta->methodCount(); i++) {
		QMetaMethod m = meta->method(i);
		if (	m.methodType() == QMetaMethod::Signal 
				&& strcmp(m.signature(), signature) == 0 )
		{
			break;
		}
	}

	QList<MocArgument*> args = GetMocArguments(o->smoke, meta->method(i).typeName(), meta->method(i).parameterTypes());
	
	Qyoto::EmitSignal signal(qobj, i, items, args, sp);
	signal.next();

	(*FreeGCHandle)(obj);
	return true;
}

Q_DECL_EXPORT void*
qyoto_make_metaObject(const char* parentClassName, void* parentMeta, const char* stringdata, int stringdata_count,
                const uint* data, int data_count)
{
	QMetaObject* parent = 0;

	if (parentMeta == 0) {
		// The parent class is a Smoke class, so call metaObject() on the
		// instance to get it via a smoke library call
		parent = get_meta_object(parentClassName);
	} else {
		// The parent class is a custom C# class whose metaObject
		// was constructed at runtime
		smokeqyoto_object* o = (smokeqyoto_object*) (*GetSmokeObject)(parentMeta);
		parent = (QMetaObject *) o->ptr;
		(*FreeGCHandle)(parentMeta);
	}

	char* my_stringdata = new char[stringdata_count];
	memcpy(my_stringdata, stringdata, stringdata_count * sizeof(char));
	
	uint* my_data = new uint[data_count];
	memcpy(my_data, data, data_count * sizeof(uint));
	
	// create a QMetaObject on the stack
	QMetaObject tmp = {{
		parent,
		my_stringdata,
		my_data,
		0
	}};
	
	// copy it to the heap
	QMetaObject* meta = new QMetaObject;
	*meta = tmp;

#ifdef DEBUG
	printf("make_metaObject() superdata: %p %s\n", meta->d.superdata, parent->className());
	
	printf(
	" // content:\n"
	"       %d,       // revision\n"
	"       %d,       // classname\n"
	"       %d,   %d, // classinfo\n"
	"       %d,   %d, // methods\n"
	"       %d,   %d, // properties\n"
	"       %d,   %d, // enums/sets\n",
	data[0], data[1], data[2], data[3], 
	data[4], data[5], data[6], data[7], data[8], data[9]);

	int s = data[3];

	if (data[2] > 0) {
		printf("\n // classinfo: key, value\n");
		for (uint j = 0; j < data[2]; j++) {
			printf("      %d,    %d\n", data[s + (j * 2)], data[s + (j * 2) + 1]);
		}
	}

	s = data[5];
	bool signal_headings = true;
	bool slot_headings = true;

	for (uint j = 0; j < data[4]; j++) {
		if (signal_headings && (data[s + (j * 5) + 4] & 0x04) != 0) {
			printf("\n // signals: signature, parameters, type, tag, flags\n");
			signal_headings = false;
		} 

		if (slot_headings && (data[s + (j * 5) + 4] & 0x08) != 0) {
			printf("\n // slots: signature, parameters, type, tag, flags\n");
			slot_headings = false;
		}

		printf("      %d,   %d,   %d,   %d, 0x%2.2x\n", 
			data[s + (j * 5)], data[s + (j * 5) + 1], data[s + (j * 5) + 2], 
			data[s + (j * 5) + 3], data[s + (j * 5) + 4]);
	}

	s += (data[4] * 5);
	for (uint j = 0; j < data[6]; j++) {
		printf("\n // properties: name, type, flags\n");
		printf("      %d,   %d,   0x%8.8x\n", 
			data[s + (j * 3)], data[s + (j * 3) + 1], data[s + (j * 3) + 2]);
	}

	s += (data[6] * 3);
	for (int i = s; i < data_count; i++) {
		printf("\n       %d        // eod\n", data[i]);
	}

	printf("\nqt_meta_stringdata:\n    \"");

    int strlength = 0;
	for (int j = 0; j < stringdata_count; j++) {
        strlength++;
		if (meta->d.stringdata[j] == 0) {
			printf("\\0");
			if (strlength > 40) {
				printf("\"\n    \"");
				strlength = 0;
			}
		} else {
			printf("%c", meta->d.stringdata[j]);
		}
	}
	printf("\"\n");
#endif
	
	// create smoke object
	smokeqyoto_object  * m = alloc_smokeqyoto_object(	true, 
														qtcore_Smoke,
														qtcore_Smoke->idClass("QMetaObject").index,
														meta );
	
	// create wrapper C# instance
	return (*CreateInstance)("Qyoto.QMetaObject", m);
}

#define INIT_BINDING(module) \
    static QHash<int,char *> module##_classname; \
    for (int i = 1; i <= module##_Smoke->numClasses; i++) { \
        QByteArray name(module##_Smoke->classes[i].className); \
        name.replace("::", "."); \
        if (name != "QAccessible2" && name != "QDBus" && name != "QGL" && name != "QSql" && name != "QSsl") { \
            name = prefix + name; \
        } \
        module##_classname.insert(i, strdup(name.constData())); \
    } \
    static Qyoto::Binding module##_binding = Qyoto::Binding(module##_Smoke, &module##_classname); \
    QyotoModule module = { "Qyoto_" #module, qyoto_resolve_classname_qt, IsContainedInstanceQt, &module##_binding }; \
    qyoto_modules[module##_Smoke] = module;


Q_DECL_EXPORT void
Init_qyoto()
{
    init_qtcore_Smoke();
    init_qtgui_Smoke();
    init_qtxml_Smoke();
    init_qtsql_Smoke();
    init_qtopengl_Smoke();
    init_qtnetwork_Smoke();
    init_qtsvg_Smoke();
    init_qtdbus_Smoke();

    qyoto_install_handlers(Qyoto_handlers);
    QByteArray prefix("Qyoto.");

    INIT_BINDING(qtcore)
    INIT_BINDING(qtgui)
    INIT_BINDING(qtxml)
    INIT_BINDING(qtsql)
    INIT_BINDING(qtopengl)
    INIT_BINDING(qtnetwork)
    INIT_BINDING(qtsvg)
    INIT_BINDING(qtdbus)

#if QT_VERSION >= 0x40300
    QInternal::registerCallback(QInternal::EventNotifyCallback, qyoto_event_notify);
#endif
}

}

