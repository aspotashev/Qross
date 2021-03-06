//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QResource")]
    public class QResource : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QResource(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QResource), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QResource() {
            staticInterceptor = new SmokeInvocation(typeof(QResource), null);
        }
        public QResource(string file, QLocale locale) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QResource$#", "QResource(const QString&, const QLocale&)", typeof(void), typeof(string), file, typeof(QLocale), locale);
        }
        public QResource(string file) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QResource$", "QResource(const QString&)", typeof(void), typeof(string), file);
        }
        public QResource() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QResource", "QResource()", typeof(void));
        }
        public void SetFileName(string file) {
            interceptor.Invoke("setFileName$", "setFileName(const QString&)", typeof(void), typeof(string), file);
        }
        public string FileName() {
            return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
        }
        public string AbsoluteFilePath() {
            return (string) interceptor.Invoke("absoluteFilePath", "absoluteFilePath() const", typeof(string));
        }
        public void SetLocale(QLocale locale) {
            interceptor.Invoke("setLocale#", "setLocale(const QLocale&)", typeof(void), typeof(QLocale), locale);
        }
        public QLocale Locale() {
            return (QLocale) interceptor.Invoke("locale", "locale() const", typeof(QLocale));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public bool IsCompressed() {
            return (bool) interceptor.Invoke("isCompressed", "isCompressed() const", typeof(bool));
        }
        public long Size() {
            return (long) interceptor.Invoke("size", "size() const", typeof(long));
        }
        public Pointer<byte> Data() {
            return (Pointer<byte>) interceptor.Invoke("data", "data() const", typeof(Pointer<byte>));
        }
        protected bool IsDir() {
            return (bool) interceptor.Invoke("isDir", "isDir() const", typeof(bool));
        }
        protected bool IsFile() {
            return (bool) interceptor.Invoke("isFile", "isFile() const", typeof(bool));
        }
        protected List<string> Children() {
            return (List<string>) interceptor.Invoke("children", "children() const", typeof(List<string>));
        }
        ~QResource() {
            interceptor.Invoke("~QResource", "~QResource()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QResource", "~QResource()", typeof(void));
        }
        public static void AddSearchPath(string path) {
            staticInterceptor.Invoke("addSearchPath$", "addSearchPath(const QString&)", typeof(void), typeof(string), path);
        }
        public static List<string> SearchPaths() {
            return (List<string>) staticInterceptor.Invoke("searchPaths", "searchPaths()", typeof(List<string>));
        }
        public static bool RegisterResource(string rccFilename, string resourceRoot) {
            return (bool) staticInterceptor.Invoke("registerResource$$", "registerResource(const QString&, const QString&)", typeof(bool), typeof(string), rccFilename, typeof(string), resourceRoot);
        }
        public static bool RegisterResource(string rccFilename) {
            return (bool) staticInterceptor.Invoke("registerResource$", "registerResource(const QString&)", typeof(bool), typeof(string), rccFilename);
        }
        public static bool UnregisterResource(string rccFilename, string resourceRoot) {
            return (bool) staticInterceptor.Invoke("unregisterResource$$", "unregisterResource(const QString&, const QString&)", typeof(bool), typeof(string), rccFilename, typeof(string), resourceRoot);
        }
        public static bool UnregisterResource(string rccFilename) {
            return (bool) staticInterceptor.Invoke("unregisterResource$", "unregisterResource(const QString&)", typeof(bool), typeof(string), rccFilename);
        }
        public static bool RegisterResource(Pointer<byte> rccData, string resourceRoot) {
            return (bool) staticInterceptor.Invoke("registerResource$$", "registerResource(const uchar*, const QString&)", typeof(bool), typeof(Pointer<byte>), rccData, typeof(string), resourceRoot);
        }
        public static bool RegisterResource(Pointer<byte> rccData) {
            return (bool) staticInterceptor.Invoke("registerResource$", "registerResource(const uchar*)", typeof(bool), typeof(Pointer<byte>), rccData);
        }
        public static bool UnregisterResource(Pointer<byte> rccData, string resourceRoot) {
            return (bool) staticInterceptor.Invoke("unregisterResource$$", "unregisterResource(const uchar*, const QString&)", typeof(bool), typeof(Pointer<byte>), rccData, typeof(string), resourceRoot);
        }
        public static bool UnregisterResource(Pointer<byte> rccData) {
            return (bool) staticInterceptor.Invoke("unregisterResource$", "unregisterResource(const uchar*)", typeof(bool), typeof(Pointer<byte>), rccData);
        }
    }
}
