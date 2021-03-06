//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;

    public interface IQXmlErrorHandler {
        bool Warning(QXmlParseException exception);
        bool Error(QXmlParseException exception);
        bool FatalError(QXmlParseException exception);
        string ErrorString();
    }
    [SmokeClass("QXmlErrorHandler")]
    public abstract class QXmlErrorHandler : Object, IQXmlErrorHandler {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QXmlErrorHandler(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QXmlErrorHandler), this);
        }
        [SmokeMethod("warning(const QXmlParseException&)")]
        public abstract bool Warning(QXmlParseException exception);
        [SmokeMethod("error(const QXmlParseException&)")]
        public abstract bool Error(QXmlParseException exception);
        [SmokeMethod("fatalError(const QXmlParseException&)")]
        public abstract bool FatalError(QXmlParseException exception);
        [SmokeMethod("errorString() const")]
        public abstract string ErrorString();
        public QXmlErrorHandler() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QXmlErrorHandler", "QXmlErrorHandler()", typeof(void));
        }
    }
}
