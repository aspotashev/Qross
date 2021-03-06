/*
    Copyright (C) 2009 Arno Rehn <arno@arnorehn.de>

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

#ifndef GENERATOR_OPTIONS_H
#define GENERATOR_OPTIONS_H

#include "generator_export.h"

class QDir;
class QFileInfo;
template<typename T>
class QSet;
template<typename T>
class QList;
class QRegExp;
class QStringList;

class Typedef;

struct GENERATOR_EXPORT ParserOptions
{
    static QFileInfo definesList;
    static QList<QFileInfo> headerList;
    static QList<QDir> includeDirs;
    static bool resolveTypedefs;
    static bool qtMode;
    static QStringList dropMacros;
};

extern GENERATOR_EXPORT QSet<const Typedef*> flagTypes;

#endif
