PROJECT(qtwebkit-sharp)

IF (NOT QT4_FOUND)
	FIND_PACKAGE(Qt4 REQUIRED)
ENDIF (NOT QT4_FOUND)

SET(SRC_CPP src/qtwebkit.cpp src/qtwebkithandlers.cpp)

SET(SRC_CS src/QtWebKit.cs
	src/AssemblyInfo.cs
	qtwebkit/*.cs)

INCLUDE_DIRECTORIES(${CMAKE_SOURCE_DIR}/smoke 
	${CMAKE_CURRENT_SOURCE_DIR}/../qyoto/src ${QT_INCLUDES})
LINK_DIRECTORIES (${LIBRARY_OUTPUT_PATH})
ADD_LIBRARY(qtwebkit-sharp MODULE ${SRC_CPP})
TARGET_LINK_LIBRARIES(qtwebkit-sharp smokeqtwebkit qyotoshared ${QT_QTCORE_LIBRARY} ${QT_QTGUI_LIBRARY} ${QT_QTWEBKIT_LIBRARY})

CSHARP_ADD_LIBRARY(qtwebkit "${SRC_CS}" REFERENCES qt-dotnet COMPILE_FLAGS /warn:0 /keyfile:${KEYFILE})
SET_PROPERTY(TARGET qtwebkit PROPERTY pkg-config_template_basename ${PROJECT_NAME})
ADD_DEPENDENCIES(qtwebkit qt-dotnet qtwebkit-sharp smokeqtwebkit)

INSTALL(TARGETS qtwebkit-sharp LIBRARY DESTINATION ${LIB_INSTALL_DIR})
INSTALL_ASSEMBLY(qtwebkit DESTINATION ${LIB_INSTALL_DIR} PACKAGE qyoto)
