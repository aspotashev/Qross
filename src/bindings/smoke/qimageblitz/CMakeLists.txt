if (NOT QIMAGEBLITZ_FOUND)
    find_package(QImageBlitz REQUIRED)
endif (NOT QIMAGEBLITZ_FOUND)

########### next target ###############

add_custom_command(OUTPUT ${CMAKE_CURRENT_BINARY_DIR}/smokedata.cpp
	${CMAKE_CURRENT_BINARY_DIR}/x_1.cpp

    COMMAND smokegen
    ARGS -config "${CMAKE_CURRENT_BINARY_DIR}/../qt/config.xml" -smokeconfig "${CMAKE_CURRENT_SOURCE_DIR}/smokeconfig.xml"
         -I ${QIMAGEBLITZ_INCLUDES} -- ${CMAKE_CURRENT_SOURCE_DIR}/qimageblitz_includes.h
    DEPENDS smokegen generator_smoke WORKING_DIRECTORY ${CMAKE_CURRENT_BINARY_DIR})

macro_add_file_dependencies( ${CMAKE_CURRENT_BINARY_DIR}/smokedata.cpp ${CMAKE_CURRENT_BINARY_DIR}/x_1.cpp )

include_directories( ${QT_INCLUDES} ${QIMAGEBLITZ_INCLUDES} ${CMAKE_SOURCE_DIR}/smoke  )

set(smokeqimageblitz_LIB_SRCS ${CMAKE_CURRENT_BINARY_DIR}/smokedata.cpp
	${CMAKE_CURRENT_BINARY_DIR}/x_1.cpp)

IF(CMAKE_CXX_FLAGS MATCHES "-fvisibility")
    ADD_DEFINITIONS(-DGCC_VISIBILITY)
ENDIF(CMAKE_CXX_FLAGS MATCHES "-fvisibility")
add_library(smokeqimageblitz SHARED ${smokeqimageblitz_LIB_SRCS})

target_link_libraries(smokeqimageblitz smokeqtcore smokeqtgui ${QT_QTCORE_LIBRARY} ${QT_QTGUI_LIBRARY} ${QIMAGEBLITZ_LIBRARIES})

set_target_properties(smokeqimageblitz PROPERTIES VERSION 3.0.0 SOVERSION 3 )

install(TARGETS smokeqimageblitz DESTINATION ${CMAKE_INSTALL_PREFIX}/lib${LIB_SUFFIX} )
install(FILES ${CMAKE_SOURCE_DIR}/smoke/qimageblitz_smoke.h DESTINATION include/smoke )
