//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QBitRef")]
    public class QBitRef : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QBitRef(Type dummy) {}
        private static SmokeInvocation staticInterceptor = null;
        static QBitRef() {
            staticInterceptor = new SmokeInvocation(typeof(QBitRef), null);
        }
        public static bool operatorbool(QBitRef lhs) {
            return (bool) staticInterceptor.Invoke("operator bool", "operator bool() const", typeof(bool), typeof(QBitRef), lhs);
        }
        public static bool operator!(QBitRef lhs) {
            return (bool) staticInterceptor.Invoke("operator!", "operator!() const", typeof(bool), typeof(QBitRef), lhs);
        }
    }
}
