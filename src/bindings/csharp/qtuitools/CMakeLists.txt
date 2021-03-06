PROJECT(qtuitools-sharp)

IF (NOT QT4_FOUND)
	FIND_PACKAGE(Qt4 REQUIRED)
ENDIF (NOT QT4_FOUND)

SET(SRC_CPP src/qtuitools.cpp src/qtuitoolshandlers.cpp)

SET(SRC_CS src/QtUiTools.cs
	src/AssemblyInfo.cs
	qtuitools/*.cs)

INCLUDE_DIRECTORIES(${CMAKE_SOURCE_DIR}/smoke 
	${CMAKE_CURRENT_SOURCE_DIR}/../qyoto/src ${QT_INCLUDES})
LINK_DIRECTORIES (${LIBRARY_OUTPUT_PATH})
ADD_LIBRARY(qtuitools-sharp MODULE ${SRC_CPP})
TARGET_LINK_LIBRARIES(qtuitools-sharp smokeqtuitools qyotoshared ${QT_QTCORE_LIBRARY} ${QT_QTGUI_LIBRARY} ${QT_QTUITOOLS_LIBRARY})

CSHARP_ADD_LIBRARY(qtuitools "${SRC_CS}" REFERENCES qt-dotnet COMPILE_FLAGS /warn:0 /keyfile:${KEYFILE})
SET_PROPERTY(TARGET qtuitools PROPERTY pkg-config_template_basename ${PROJECT_NAME})
ADD_DEPENDENCIES(qtuitools qt-dotnet qtuitools-sharp smokeqtuitools)

INSTALL(TARGETS qtuitools-sharp LIBRARY DESTINATION ${LIB_INSTALL_DIR})
INSTALL_ASSEMBLY(qtuitools DESTINATION ${LIB_INSTALL_DIR} PACKAGE qyoto)
