//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  Extracted from kapplication (3.x). Kiosk authorization framework
    /// </remarks>        <short>    Extracted from kapplication (3.</short>
    [SmokeClass("KAuthorized")]
    public class KAuthorized {
        private static SmokeInvocation staticInterceptor = null;
        static KAuthorized() {
            staticInterceptor = new SmokeInvocation(typeof(KAuthorized), null);
        }
        /// <remarks>
        ///  Returns whether a certain action is authorized
        /// <param> name="genericAction" The name of a generic action
        /// </param></remarks>        <return> true if the action is authorized
        ///  @todo what are the generic actions?
        ///    </return>
        ///         <short>    Returns whether a certain action is authorized </short>
        public static bool Authorize(string genericAction) {
            return (bool) staticInterceptor.Invoke("authorize$", "authorize(const QString&)", typeof(bool), typeof(string), genericAction);
        }
        /// <remarks>
        ///  Returns whether a certain KAction is authorized.
        /// <param> name="action" The name of a KAction action. The name is prepended
        ///  with "action/" before being passed to authorize()
        /// </param></remarks>        <return> true if the KAction is authorized
        ///    </return>
        ///         <short>    Returns whether a certain KAction is authorized.</short>
        public static bool AuthorizeKAction(string action) {
            return (bool) staticInterceptor.Invoke("authorizeKAction$", "authorizeKAction(const QString&)", typeof(bool), typeof(string), action);
        }
        /// <remarks>
        ///  Returns whether a certain URL related action is authorized.
        /// <param> name="action" The name of the action. Known actions are
        ///   - list (may be listed (e.g. in file selection dialog)),
        ///   - link (may be linked to),
        ///   - open (may open) and
        ///   - redirect (may be redirected to)
        /// </param><param> name="baseUrl" The url where the action originates from
        /// </param><param> name="destUrl" The object of the action
        /// </param></remarks>        <return> true when the action is authorized, false otherwise.
        ///    </return>
        ///         <short>    Returns whether a certain URL related action is authorized.</short>
        public static bool AuthorizeUrlAction(string action, KUrl baseUrl, KUrl destUrl) {
            return (bool) staticInterceptor.Invoke("authorizeUrlAction$##", "authorizeUrlAction(const QString&, const KUrl&, const KUrl&)", typeof(bool), typeof(string), action, typeof(KUrl), baseUrl, typeof(KUrl), destUrl);
        }
        /// <remarks>
        ///  Allow a certain URL action. This can be useful if your application
        ///  needs to ensure access to an application specific directory that may
        ///  otherwise be subject to KIOSK restrictions.
        /// <param> name="action" The name of the action.
        /// </param><param> name="baseUrl" The url where the action originates from
        /// </param><param> name="_destUrl" The object of the action
        ///    </param></remarks>        <short>    Allow a certain URL action.</short>
        public static void AllowUrlAction(string action, KUrl baseUrl, KUrl _destUrl) {
            staticInterceptor.Invoke("allowUrlAction$##", "allowUrlAction(const QString&, const KUrl&, const KUrl&)", typeof(void), typeof(string), action, typeof(KUrl), baseUrl, typeof(KUrl), _destUrl);
        }
        /// <remarks>
        ///  Returns whether access to a certain control module is authorized.
        /// <param> name="menuId" identifying the control module, e.g. kde-mouse.desktop
        /// </param></remarks>        <return> true if access to the module is authorized, false otherwise.
        ///    </return>
        ///         <short>    Returns whether access to a certain control module is authorized.</short>
        public static bool AuthorizeControlModule(string menuId) {
            return (bool) staticInterceptor.Invoke("authorizeControlModule$", "authorizeControlModule(const QString&)", typeof(bool), typeof(string), menuId);
        }
        /// <remarks>
        ///  Returns which control modules from a given list are authorized for access.
        /// <param> name="menuIds" list of menu-ids of control modules;
        ///  an example of a menu-id is kde-mouse.desktop.
        /// </param></remarks>        <return> Those control modules for which access has been authorized.
        ///    </return>
        ///         <short>    Returns which control modules from a given list are authorized for access.</short>
        public static List<string> AuthorizeControlModules(List<string> menuIds) {
            return (List<string>) staticInterceptor.Invoke("authorizeControlModules?", "authorizeControlModules(const QStringList&)", typeof(List<string>), typeof(List<string>), menuIds);
        }
    }
}
