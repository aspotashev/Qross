#
# to use the file to build a Qt only version of PHP-Qt, copy it to CMakeLists.txt
#
# run prepare_svn.sh
# make a build/ dir, step into
# run: cmake ..
# run: make
#
# for further information read the README file in php/phpqt
#

cmake_minimum_required(VERSION 2.6)

project(PHP-Qt)

# where to look first for cmake modules, before ${CMAKE_ROOT}/Modules/ is checked
set(CMAKE_MODULE_PATH ${CMAKE_SOURCE_DIR}/cmake/modules )

FIND_PACKAGE(Perl REQUIRED)
set( QT_MIN_VERSION "4.4.0" )
FIND_PACKAGE (Qt4 REQUIRED)
Find_PACKAGE(Doxygen) # optional

add_definitions (${QT_DEFINITIONS}  -DHAVE_CONFIG_H=1)
include_directories (${CMAKE_SOURCE_DIR} ${CMAKE_BINARY_DIR} ${QT_INCLUDES} )

FIND_PACKAGE (PHP5 REQUIRED)
FIND_PACKAGE (OpenGL REQUIRED)

OPTION(ENABLE_SMOKE "build Smoke" OFF)
OPTION(ENABLE_PLASMA_SMOKE "build PlasmaSmoke" OFF)
OPTION(ENABLE_QTWEBKIT_SMOKE "build QtWebKitSmoke" OFF)
OPTION(ENABLE_QTSCRIPT_SMOKE "build QtScriptSmoke" OFF)
OPTION(ENABLE_QTUITOOLS_SMOKE "build QtUiToolsSmoke" OFF)
OPTION(ENABLE_PHONON_SMOKE "build PhononSmoke" OFF)
OPTION(ENABLE_QSCI_SMOKE "build QsciSmoke" OFF)
OPTION(ENABLE_QWT_SMOKE "build QwtSmoke" OFF)
OPTION(ENABLE_KDE_SMOKE "build KDESmoke" OFF)
OPTION(ENABLE_KDEVPLATFORM_SMOKE "build KDevPlatformSmoke" OFF)
OPTION(ENABLE_KHTML_SMOKE "build KHTMLSmoke" OFF)
OPTION(ENABLE_KTEXTEDITOR_SMOKE "build KTextEditorSmoke" OFF)
OPTION(ENABLE_SOLID_SMOKE "build SolidSmoke" OFF)
OPTION(ENABLE_PHP-QT "build PHP-Qt" ON)

set(kdebindings_SOURCE_DIR ${CMAKE_SOURCE_DIR})
# add_subdirectory(smoke)
add_subdirectory(src)
add_subdirectory(tests)
add_subdirectory(tools)
include(tests/CMakeLists.txt)

if(PHPUNIT_EXECUTABLE)
  MESSAGE(STATUS "phpunit found: configuring for tests")
  ENABLE_TESTING()
  SET(RUNTIME_OUTPUT_DIRECTORY_ORIG)
  SET(RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BUILD_DIR}php/phpqt"/tests/")

  CONFIGURE_FILE( ${CMAKE_CURRENT_SOURCE_DIR}/tests/config.php.conf ${CMAKE_BUILD_DIR}php/phpqt/tests/config.php @ONLY )
  FOREACH(TEST_CASE ${PHPQT_TEST_FILES} )
    CONFIGURE_FILE( ${CMAKE_CURRENT_SOURCE_DIR}/tests/${TEST_CASE} ${CMAKE_BUILD_DIR}php/phpqt/tests/${TEST_CASE} COPYONLY )
    ADD_TEST( ${TEST_CASE} ${PHPUNIT_EXECUTABLE} --log-tap ${TEST_CASE}.log ${TEST_CASE} )
    MESSAGE(STATUS "added "${TEST_CASE} )
  ENDFOREACH(TEST_CASE)

  SET(RUNTIME_OUTPUT_DIRECTORY ${RUNTIME_OUTPUT_DIRECTORY_ORIG})
elseif(PHPUNIT_EXECUTABLE)
  MESSAGE(STATUS "no tests configured (needs phpunit)")
endif(PHPUNIT_EXECUTABLE)

IF(DOXYGEN_FOUND)
  SET(DOXYFILE_UNITTESTS Doxyfile.unittests)
  ADD_CUSTOM_TARGET(doc_unittests ${DOXYGEN_EXECUTABLE} ${DOXYFILE_UNITTESTS} WORKING_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR})
  SET(DOXYFILE_INTERNALS Doxyfile.internals)
  ADD_CUSTOM_TARGET(doc_internals ${DOXYGEN_EXECUTABLE} ${DOXYFILE_INTERNALS} WORKING_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR})
ENDIF(DOXYGEN_FOUND)
