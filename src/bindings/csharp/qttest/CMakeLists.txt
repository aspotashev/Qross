PROJECT(qttest-sharp)

IF (NOT QT4_FOUND)
	FIND_PACKAGE(Qt4 REQUIRED)
ENDIF (NOT QT4_FOUND)

SET(SRC_CPP src/qttest.cpp src/qttesthandlers.cpp)

SET(SRC_CS src/QtTest.cs
	src/AssemblyInfo.cs
	qttest/*.cs)

INCLUDE_DIRECTORIES(${CMAKE_SOURCE_DIR}/smoke 
	${CMAKE_CURRENT_SOURCE_DIR}/../qyoto/src ${QT_INCLUDES})
LINK_DIRECTORIES (${LIBRARY_OUTPUT_PATH})
ADD_LIBRARY(qttest-sharp MODULE ${SRC_CPP})
TARGET_LINK_LIBRARIES(qttest-sharp smokeqttest qyotoshared ${QT_QTCORE_LIBRARY} ${QT_QTGUI_LIBRARY} ${QT_QTTEST_LIBRARY})

CSHARP_ADD_LIBRARY(qttest "${SRC_CS}" REFERENCES qt-dotnet COMPILE_FLAGS /warn:0 /keyfile:${KEYFILE})
SET_PROPERTY(TARGET qttest PROPERTY pkg-config_template_basename ${PROJECT_NAME})
ADD_DEPENDENCIES(qttest qt-dotnet)

INSTALL(TARGETS qttest-sharp LIBRARY DESTINATION ${LIB_INSTALL_DIR})
INSTALL_ASSEMBLY(qttest DESTINATION ${LIB_INSTALL_DIR} PACKAGE qyoto)
