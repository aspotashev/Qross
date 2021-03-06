//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Text;
    /// <remarks>
    ///  KDE Accelerator manager.
    ///  This class can be used to find a valid and working set of
    ///  accelerators for any widget.
    /// </remarks>        <author> Matthias Hölzer-Klüpfel <mhk@kde.org>
    /// </author>
    ///         <short>    KDE Accelerator manager.</short>
    [SmokeClass("KAcceleratorManager")]
    public class KAcceleratorManager : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KAcceleratorManager(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KAcceleratorManager), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KAcceleratorManager() {
            staticInterceptor = new SmokeInvocation(typeof(KAcceleratorManager), null);
        }
        public KAcceleratorManager() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAcceleratorManager", "KAcceleratorManager()", typeof(void));
        }
        ~KAcceleratorManager() {
            interceptor.Invoke("~KAcceleratorManager", "~KAcceleratorManager()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KAcceleratorManager", "~KAcceleratorManager()", typeof(void));
        }
        /// <remarks>
        ///  Manages the accelerators of a widget.
        ///  Call this function on the top widget of the hierarchy you
        ///  want to manage. It will fix the accelerators of the child widgets so
        ///  there are never duplicate accelerators. It also tries to put
        ///  accelerators on as many widgets as possible.
        ///  The algorithm used tries to take the existing accelerators into
        ///  account, as well as the class of each widget. Hopefully, the result
        ///  is close to what you would assign manually.
        ///  QPopupMenu's are managed dynamically, so when you add or remove entries,
        ///  the accelerators are reassigned. If you add or remove widgets to your
        ///  toplevel widget, you will have to call manage again to fix the
        ///  accelerators.
        /// <param> name="widget" The toplevel widget you want to manage.
        /// </param><param> name="programmers_mode" if true, KAcceleratorManager adds (&) for removed
        ///              accels and & before added accels
        ///      </param></remarks>        <short>    Manages the accelerators of a widget.</short>
        public static void Manage(QWidget widget, bool programmers_mode) {
            staticInterceptor.Invoke("manage#$", "manage(QWidget*, bool)", typeof(void), typeof(QWidget), widget, typeof(bool), programmers_mode);
        }
        public static void Manage(QWidget widget) {
            staticInterceptor.Invoke("manage#", "manage(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks> \internal returns the result of the last manage operation. </remarks>        <short>   \internal returns the result of the last manage operation.</short>
        public static void Last_manage(StringBuilder added, StringBuilder changed, StringBuilder removed) {
            staticInterceptor.Invoke("last_manage$$$", "last_manage(QString&, QString&, QString&)", typeof(void), typeof(StringBuilder), added, typeof(StringBuilder), changed, typeof(StringBuilder), removed);
        }
        /// <remarks>
        ///  Use this method for a widget (and its children) you want no accels to be set on.
        ///      </remarks>        <short>    Use this method for a widget (and its children) you want no accels to be set on.</short>
        public static void SetNoAccel(QWidget widget) {
            staticInterceptor.Invoke("setNoAccel#", "setNoAccel(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
    }
}
