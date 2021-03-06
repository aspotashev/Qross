/***************************************************************************
 * interpreter.cpp
 * This file is part of the KDE project
 * copyright (C)2007-2008 by Sebastian Sauer (mail@dipe.org)
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

#include "interpreter.h"
#include "script.h"

// The in qrossconfig.h defined QROSS_EXPORT_INTERPRETER macro defines an
// exported C function used as factory for Qross::EcmaInterpreter instances.
QROSS_EXPORT_INTERPRETER( Qross::EcmaInterpreter )

using namespace Qross;

namespace Qross {

    /// \internal private d-pointer class.
    class EcmaInterpreter::Private
    {
        public:
    };

}

EcmaInterpreter::EcmaInterpreter(Qross::InterpreterInfo* info)
    : Qross::Interpreter(info)
    , d(new Private())
{
    //qrossdebug( QString("EcmaInterpreter::EcmaInterpreter") );
}

EcmaInterpreter::~EcmaInterpreter()
{
    //qrossdebug( QString("EcmaInterpreter::~EcmaInterpreter") );
    delete d;
}

Qross::Script* EcmaInterpreter::createScript(Qross::Action* action)
{
    return new EcmaScript(this, action);
}

