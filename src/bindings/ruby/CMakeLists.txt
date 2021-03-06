macro_optional_find_package(RUBY)

#####################################################################
# QtRuby/Korundum

OPTION(ENABLE_QTRUBY "build QtRuby" ON)
OPTION(ENABLE_QTWEBKIT_RUBY "build QtWebKit" ON)
OPTION(ENABLE_QTUITOOLS_RUBY "build QtUiTools" ON)
OPTION(ENABLE_QTSCRIPT "build QtScript" ON)
OPTION(ENABLE_QTTEST "build QtTest" ON)

OPTION(ENABLE_PHONON_RUBY "build Phonon" OFF)
OPTION(ENABLE_QSCINTILLA_RUBY "build QScintilla" OFF)
OPTION(ENABLE_QWT_RUBY "build Qwt" OFF)
OPTION(ENABLE_SOPRANO_RUBY "build Soprano" OFF)

OPTION(ENABLE_KDEVPLATFORM_RUBY "build KDevPlatform" OFF)
OPTION(ENABLE_KORUNDUM_RUBY "build Korundum" ON)
OPTION(ENABLE_KHTML_RUBY "build KHTML" ON)
OPTION(ENABLE_KTEXTEDITOR_RUBY "build KTextEditor" ON)
OPTION(ENABLE_SOLID_RUBY "build Solid" ON)
OPTION(ENABLE_PLASMA_RUBY "build Plasma" ON)

SET(CUSTOM_RUBY_SITE_ARCH_DIR ${RUBY_SITE_ARCH_DIR} CACHE DIR "custom installation directory for ruby binary extension" )
SET(CUSTOM_RUBY_SITE_LIB_DIR ${RUBY_SITE_LIB_DIR} CACHE DIR "custom installation directory for ruby extension" )

set(QTRUBY_ENABLED "no")
set(QTWEBKIT_ENABLED "no")
set(QTUITOOLS_ENABLED "no")
set(QTSCRIPT_ENABLED "no")
set(QTTEST_ENABLED "no")

set(PHONON_ENABLED "no")
set(QSCINTILLA_ENABLED "no")
set(QWT_ENABLED "no")
set(SOPRANO_ENABLED "no")

set(AKONADI_ENABLED "no")
set(KDEVPLATFORM_ENABLED "no")
set(KORUNDUM_ENABLED "no")
set(KHTML_ENABLED "no")
set(KTEXTEDITOR_ENABLED "no")
set(NEPOMUK_ENABLED "no")
set(OKULAR_ENABLED "no")
set(SOLID_ENABLED "no")
set(PLASMA_ENABLED "no")

if(RUBY_EXECUTABLE AND RUBY_LIBRARY AND RUBY_INCLUDE_PATH)
   EXECUTE_PROCESS(COMMAND ${RUBY_EXECUTABLE} -e "print RUBY_VERSION"
      OUTPUT_VARIABLE RUBY_VERSION)

    STRING(REGEX REPLACE "^([0-9]+)\\.[0-9]+\\.[0-9]+.*" "\\1" RUBY_VERSION_MAJOR "${RUBY_VERSION}")
    STRING(REGEX REPLACE "^[0-9]+\\.([0-9])+\\.[0-9]+.*" "\\1" RUBY_VERSION_MINOR "${RUBY_VERSION}")
    STRING(REGEX REPLACE "^[0-9]+\\.[0-9]+\\.([0-9]+).*" "\\1" RUBY_VERSION_PATCH "${RUBY_VERSION}")

    # compute an overall version number which can be compared at once
    MATH(EXPR RUBY_VERSION_NUMBER "${RUBY_VERSION_MAJOR}*10000 + ${RUBY_VERSION_MINOR}*100 + ${RUBY_VERSION_PATCH}")

    if(ENABLE_QTRUBY)
        add_subdirectory( qtruby )
        set(QTRUBY_ENABLED "yes")
    endif(ENABLE_QTRUBY)
    if(ENABLE_QTWEBKIT_RUBY)
        add_subdirectory( qtwebkit )
        set(QTWEBKIT_ENABLED "yes")
    endif(ENABLE_QTWEBKIT_RUBY)
    if(ENABLE_QTUITOOLS_RUBY)
        add_subdirectory( qtuitools )
        set(QTUITOOLS_ENABLED "yes")
    endif(ENABLE_QTUITOOLS_RUBY)
    if(ENABLE_QTSCRIPT)
        add_subdirectory( qtscript )
        set(QTSCRIPT_ENABLED "yes")
    endif(ENABLE_QTSCRIPT)
    if(ENABLE_QTTEST)
        add_subdirectory( qttest )
        set(QTTEST_ENABLED "yes")
    endif(ENABLE_QTTEST)

    if(ENABLE_PHONON_RUBY AND PHONON_FOUND)
        add_subdirectory( phonon )
        set(PHONON_ENABLED "yes")
    endif(ENABLE_PHONON_RUBY AND PHONON_FOUND)
    if(ENABLE_QSCINTILLA_RUBY AND QSCINTILLA_FOUND)
        add_subdirectory( qscintilla )
        set(QSCINTILLA_ENABLED "yes")
    endif(ENABLE_QSCINTILLA_RUBY AND QSCINTILLA_FOUND)
    if(ENABLE_QWT_RUBY)
        add_subdirectory( qwt )
        set(QWT_ENABLED "yes")
    endif(ENABLE_QWT_RUBY)
    
    if(Soprano_FOUND)
        add_subdirectory( soprano )
        set(SOPRANO_ENABLED "yes")
    endif(Soprano_FOUND)

    if(KDEPIMLIBS_FOUND AND Akonadi_FOUND)
        add_subdirectory( akonadi )
        set(AKONADI_ENABLED "yes")
    endif(KDEPIMLIBS_FOUND AND Akonadi_FOUND)
    
    if(ENABLE_KORUNDUM_RUBY)
        add_subdirectory( korundum )
        set(KORUNDUM_ENABLED "yes")
    endif(ENABLE_KORUNDUM_RUBY)
    
    if(ENABLE_KHTML_RUBY)
        add_subdirectory( khtml )
        set(KHTML_ENABLED "yes")
    endif(ENABLE_KHTML_RUBY)
    if(ENABLE_KTEXTEDITOR_RUBY)
        add_subdirectory( ktexteditor )
        set(KTEXTEDITOR_ENABLED "yes")
    endif(ENABLE_KTEXTEDITOR_RUBY)
    if(Nepomuk_FOUND)
	add_subdirectory( nepomuk )
        set(NEPOMUK_ENABLED "yes")
    endif(Nepomuk_FOUND)
    if(OKULAR_FOUND)
        add_subdirectory( okular )
        set(OKULAR_ENABLED "yes")
    endif(OKULAR_FOUND)
    if(ENABLE_PLASMA_RUBY)
        add_subdirectory( plasma )
        set(PLASMA_ENABLED "yes")
    endif(ENABLE_PLASMA_RUBY)
    if(ENABLE_SOLID_RUBY)
        add_subdirectory( solid )
        set(SOLID_ENABLED "yes")
    endif(ENABLE_SOLID_RUBY)
endif(RUBY_EXECUTABLE AND RUBY_LIBRARY AND RUBY_INCLUDE_PATH)

message(STATUS "Build QtRuby... " ${QTRUBY_ENABLED})
message(STATUS "Build QtWebKit Ruby... " ${QTWEBKIT_ENABLED})
message(STATUS "Build QtUiTools Ruby... " ${QTUITOOLS_ENABLED})
message(STATUS "Build QtScript... " ${QTSCRIPT_ENABLED})
message(STATUS "Build QtTest... " ${QTTEST_ENABLED})

message(STATUS "Build Soprano Ruby... " ${SOPRANO_ENABLED})
message(STATUS "Build QScintilla Ruby... " ${QSCINTILLA_ENABLED})
message(STATUS "Build Qwt Ruby... " ${QWT_ENABLED})
message(STATUS "Build Phonon Ruby... " ${PHONON_ENABLED})

message(STATUS "Build Akonadi Ruby... " ${AKONADI_ENABLED})
message(STATUS "Build KHTML Ruby... " ${KHTML_ENABLED})
message(STATUS "Build Korundum... " ${KORUNDUM_ENABLED})
message(STATUS "Build KDevPlatform Ruby... " ${KDEVPLATFORM_ENABLED})
message(STATUS "Build KTextEditor Ruby... " ${KTEXTEDITOR_ENABLED})
message(STATUS "Build Nepomuk Ruby... " ${NEPOMUK_ENABLED})
message(STATUS "Build Okular Ruby... " ${OKULAR_ENABLED})
message(STATUS "Build Plasma Ruby... " ${PLASMA_ENABLED})
message(STATUS "Build Solid Ruby... " ${SOLID_ENABLED})

#####################################################################
# Kross Ruby

OPTION(ENABLE_KROSSRUBY "build Kross Ruby scripting library" ON)
#OPTION(ENABLE_KROSSRUBY "build Kross Ruby scripting library" OFF)

set(KROSSRUBY_ENABLED "no")
if(ENABLE_KROSSRUBY)
    if (RUBY_EXECUTABLE AND RUBY_LIBRARY AND RUBY_INCLUDE_PATH)
        EXECUTE_PROCESS(COMMAND ${RUBY_EXECUTABLE} -r mkmf -e "exit(have_func('rb_hash_foreach') ? 0 : 1)" RESULT_VARIABLE RUBY_HASH_FOREACH OUTPUT_QUIET)
        if (RUBY_HASH_FOREACH EQUAL 0)

            set(CMAKE_REQUIRED_INCLUDES ${RUBY_INCLUDE_PATH})
            set(CMAKE_REQUIRED_LIBRARIES ${RUBY_LIBRARY})
            CHECK_CXX_SOURCE_COMPILES("
                #include <ruby.h>
                int main() { ruby_init(); return 0; }" RubyCompiles)
            if(RubyCompiles)
                add_subdirectory(krossruby)
                set(KROSSRUBY_ENABLED "yes")
            else(RubyCompiles)
                message(STATUS "Failed to compile a C++ program that embeds ruby.")
            endif(RubyCompiles)

        else (RUBY_HASH_FOREACH EQUAL 0)

            # 2007-02-12 sebsauer; this is a workaround for the case we failed to load
            # the "mkmf" library what is the case e.g. on some debian distributions.
            #EXECUTE_PROCESS(COMMAND ${RUBY_EXECUTABLE} -r mkmf -e "exit(0)" RESULT_VARIABLE RUBY_HASH_FOREACH OUTPUT_QUIET ERROR_QUIET)
            #if (${RUBY_HASH_FOREACH} EQUAL 0)
            message(STATUS "The detected Ruby is too old for kross. A Ruby which has rb_hash_foreach is required. Upgrade to 1.8.2 or later")
            #else (${RUBY_HASH_FOREACH} EQUAL 0)
            #    message(STATUS "Failed to load the Ruby mkmf library. Please install the Ruby developer packages.")
            #endif (${RUBY_HASH_FOREACH} EQUAL 0)

        endif (RUBY_HASH_FOREACH EQUAL 0)
    endif (RUBY_EXECUTABLE AND RUBY_LIBRARY AND RUBY_INCLUDE_PATH)
    message(STATUS "Ruby Executable: " ${RUBY_EXECUTABLE})
    message(STATUS "Ruby Libraries: " ${RUBY_LIBRARY})
    message(STATUS "Ruby Include Path: " ${RUBY_INCLUDE_PATH})
endif(ENABLE_KROSSRUBY)
message(STATUS "Build Kross Ruby... " ${KROSSRUBY_ENABLED})
