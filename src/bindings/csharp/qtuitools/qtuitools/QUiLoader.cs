//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QUiLoader")]
    public class QUiLoader : QObject, IDisposable {
        protected QUiLoader(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QUiLoader), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QUiLoader() {
            staticInterceptor = new SmokeInvocation(typeof(QUiLoader), null);
        }
        public QUiLoader(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUiLoader#", "QUiLoader(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QUiLoader() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUiLoader", "QUiLoader()", typeof(void));
        }
        public List<string> PluginPaths() {
            return (List<string>) interceptor.Invoke("pluginPaths", "pluginPaths() const", typeof(List<string>));
        }
        public void ClearPluginPaths() {
            interceptor.Invoke("clearPluginPaths", "clearPluginPaths()", typeof(void));
        }
        public void AddPluginPath(string path) {
            interceptor.Invoke("addPluginPath$", "addPluginPath(const QString&)", typeof(void), typeof(string), path);
        }
        public QWidget Load(QIODevice device, QWidget parentWidget) {
            return (QWidget) interceptor.Invoke("load##", "load(QIODevice*, QWidget*)", typeof(QWidget), typeof(QIODevice), device, typeof(QWidget), parentWidget);
        }
        public QWidget Load(QIODevice device) {
            return (QWidget) interceptor.Invoke("load#", "load(QIODevice*)", typeof(QWidget), typeof(QIODevice), device);
        }
        public List<string> AvailableWidgets() {
            return (List<string>) interceptor.Invoke("availableWidgets", "availableWidgets() const", typeof(List<string>));
        }
        [SmokeMethod("createWidget(const QString&, QWidget*, const QString&)")]
        public virtual QWidget CreateWidget(string className, QWidget parent, string name) {
            return (QWidget) interceptor.Invoke("createWidget$#$", "createWidget(const QString&, QWidget*, const QString&)", typeof(QWidget), typeof(string), className, typeof(QWidget), parent, typeof(string), name);
        }
        [SmokeMethod("createWidget(const QString&, QWidget*)")]
        public virtual QWidget CreateWidget(string className, QWidget parent) {
            return (QWidget) interceptor.Invoke("createWidget$#", "createWidget(const QString&, QWidget*)", typeof(QWidget), typeof(string), className, typeof(QWidget), parent);
        }
        [SmokeMethod("createWidget(const QString&)")]
        public virtual QWidget CreateWidget(string className) {
            return (QWidget) interceptor.Invoke("createWidget$", "createWidget(const QString&)", typeof(QWidget), typeof(string), className);
        }
        [SmokeMethod("createLayout(const QString&, QObject*, const QString&)")]
        public virtual QLayout CreateLayout(string className, QObject parent, string name) {
            return (QLayout) interceptor.Invoke("createLayout$#$", "createLayout(const QString&, QObject*, const QString&)", typeof(QLayout), typeof(string), className, typeof(QObject), parent, typeof(string), name);
        }
        [SmokeMethod("createLayout(const QString&, QObject*)")]
        public virtual QLayout CreateLayout(string className, QObject parent) {
            return (QLayout) interceptor.Invoke("createLayout$#", "createLayout(const QString&, QObject*)", typeof(QLayout), typeof(string), className, typeof(QObject), parent);
        }
        [SmokeMethod("createLayout(const QString&)")]
        public virtual QLayout CreateLayout(string className) {
            return (QLayout) interceptor.Invoke("createLayout$", "createLayout(const QString&)", typeof(QLayout), typeof(string), className);
        }
        [SmokeMethod("createActionGroup(QObject*, const QString&)")]
        public virtual QActionGroup CreateActionGroup(QObject parent, string name) {
            return (QActionGroup) interceptor.Invoke("createActionGroup#$", "createActionGroup(QObject*, const QString&)", typeof(QActionGroup), typeof(QObject), parent, typeof(string), name);
        }
        [SmokeMethod("createActionGroup(QObject*)")]
        public virtual QActionGroup CreateActionGroup(QObject parent) {
            return (QActionGroup) interceptor.Invoke("createActionGroup#", "createActionGroup(QObject*)", typeof(QActionGroup), typeof(QObject), parent);
        }
        [SmokeMethod("createActionGroup()")]
        public virtual QActionGroup CreateActionGroup() {
            return (QActionGroup) interceptor.Invoke("createActionGroup", "createActionGroup()", typeof(QActionGroup));
        }
        [SmokeMethod("createAction(QObject*, const QString&)")]
        public virtual QAction CreateAction(QObject parent, string name) {
            return (QAction) interceptor.Invoke("createAction#$", "createAction(QObject*, const QString&)", typeof(QAction), typeof(QObject), parent, typeof(string), name);
        }
        [SmokeMethod("createAction(QObject*)")]
        public virtual QAction CreateAction(QObject parent) {
            return (QAction) interceptor.Invoke("createAction#", "createAction(QObject*)", typeof(QAction), typeof(QObject), parent);
        }
        [SmokeMethod("createAction()")]
        public virtual QAction CreateAction() {
            return (QAction) interceptor.Invoke("createAction", "createAction()", typeof(QAction));
        }
        public void SetWorkingDirectory(QDir dir) {
            interceptor.Invoke("setWorkingDirectory#", "setWorkingDirectory(const QDir&)", typeof(void), typeof(QDir), dir);
        }
        public QDir WorkingDirectory() {
            return (QDir) interceptor.Invoke("workingDirectory", "workingDirectory() const", typeof(QDir));
        }
        public void SetScriptingEnabled(bool enabled) {
            interceptor.Invoke("setScriptingEnabled$", "setScriptingEnabled(bool)", typeof(void), typeof(bool), enabled);
        }
        public bool IsScriptingEnabled() {
            return (bool) interceptor.Invoke("isScriptingEnabled", "isScriptingEnabled() const", typeof(bool));
        }
        ~QUiLoader() {
            interceptor.Invoke("~QUiLoader", "~QUiLoader()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QUiLoader", "~QUiLoader()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQUiLoaderSignals Emit {
            get { return (IQUiLoaderSignals) Q_EMIT; }
        }
    }

    public interface IQUiLoaderSignals : IQObjectSignals {
    }
}
