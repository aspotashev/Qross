include_directories( ${CMAKE_SOURCE_DIR}/smoke ${RUBY_INCLUDE_PATH} ${CMAKE_SOURCE_DIR}/ruby/qtruby/src)
INCLUDE_DIRECTORIES (${QT_INCLUDES})

set(rubyktexteditor_LIBRARY_SRC ktexteditor.cpp ktexteditorhandlers.cpp)

add_library(rubyktexteditor MODULE ${rubyktexteditor_LIBRARY_SRC})
target_link_libraries(rubyktexteditor 
    ${QT_QTCORE_LIBRARY} 
    ${RUBY_LIBRARY} 
    smokeqtcore 
    smokekdecore 
    smokektexteditor 
    qtruby4shared)
set_target_properties(rubyktexteditor PROPERTIES PREFIX "" OUTPUT_NAME ktexteditor)
install(TARGETS rubyktexteditor DESTINATION ${CUSTOM_RUBY_SITE_ARCH_DIR})
install(FILES ktexteditor.rb DESTINATION ${CUSTOM_RUBY_SITE_LIB_DIR}/ktexteditor)

if (Q_WS_MAC)
    install(CODE "execute_process(COMMAND ${CMAKE_COMMAND} -E create_symlink \"${CUSTOM_RUBY_SITE_ARCH_DIR}/ktexteditor.so\"  \"${CUSTOM_RUBY_SITE_ARCH_DIR}/ktexteditor.bundle\" )" )
endif (Q_WS_MAC)
