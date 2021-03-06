//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QHttpHeader")]
    public abstract class QHttpHeader : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QHttpHeader(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QHttpHeader), this);
        }
        // QHttpHeader* QHttpHeader(QHttpHeaderPrivate& arg1,const QString& arg2); >>>> NOT CONVERTED
        // QHttpHeader* QHttpHeader(QHttpHeaderPrivate& arg1); >>>> NOT CONVERTED
        // QHttpHeader* QHttpHeader(QHttpHeaderPrivate& arg1,const QHttpHeader& arg2); >>>> NOT CONVERTED
        public QHttpHeader() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHttpHeader", "QHttpHeader()", typeof(void));
        }
        public QHttpHeader(QHttpHeader header) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHttpHeader#", "QHttpHeader(const QHttpHeader&)", typeof(void), typeof(QHttpHeader), header);
        }
        public QHttpHeader(string str) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHttpHeader$", "QHttpHeader(const QString&)", typeof(void), typeof(string), str);
        }
        public void SetValue(string key, string value) {
            interceptor.Invoke("setValue$$", "setValue(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
        }
        public void SetValues(List<QPair<string, string>> values) {
            interceptor.Invoke("setValues?", "setValues(const QList<QPair<QString,QString> >&)", typeof(void), typeof(List<QPair<string, string>>), values);
        }
        public void AddValue(string key, string value) {
            interceptor.Invoke("addValue$$", "addValue(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
        }
        public List<QPair<string, string>> Values() {
            return (List<QPair<string, string>>) interceptor.Invoke("values", "values() const", typeof(List<QPair<string, string>>));
        }
        public bool HasKey(string key) {
            return (bool) interceptor.Invoke("hasKey$", "hasKey(const QString&) const", typeof(bool), typeof(string), key);
        }
        public List<string> Keys() {
            return (List<string>) interceptor.Invoke("keys", "keys() const", typeof(List<string>));
        }
        public string Value(string key) {
            return (string) interceptor.Invoke("value$", "value(const QString&) const", typeof(string), typeof(string), key);
        }
        public List<string> AllValues(string key) {
            return (List<string>) interceptor.Invoke("allValues$", "allValues(const QString&) const", typeof(List<string>), typeof(string), key);
        }
        public void RemoveValue(string key) {
            interceptor.Invoke("removeValue$", "removeValue(const QString&)", typeof(void), typeof(string), key);
        }
        public void RemoveAllValues(string key) {
            interceptor.Invoke("removeAllValues$", "removeAllValues(const QString&)", typeof(void), typeof(string), key);
        }
        public bool HasContentLength() {
            return (bool) interceptor.Invoke("hasContentLength", "hasContentLength() const", typeof(bool));
        }
        public uint ContentLength() {
            return (uint) interceptor.Invoke("contentLength", "contentLength() const", typeof(uint));
        }
        public void SetContentLength(int len) {
            interceptor.Invoke("setContentLength$", "setContentLength(int)", typeof(void), typeof(int), len);
        }
        public bool HasContentType() {
            return (bool) interceptor.Invoke("hasContentType", "hasContentType() const", typeof(bool));
        }
        public string ContentType() {
            return (string) interceptor.Invoke("contentType", "contentType() const", typeof(string));
        }
        public void SetContentType(string type) {
            interceptor.Invoke("setContentType$", "setContentType(const QString&)", typeof(void), typeof(string), type);
        }
        [SmokeMethod("toString() const")]
        public new string ToString() {
            return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        [SmokeMethod("majorVersion() const")]
        public abstract int MajorVersion();
        [SmokeMethod("minorVersion() const")]
        public abstract int MinorVersion();
        [SmokeMethod("parseLine(const QString&, int)")]
        protected virtual bool ParseLine(string line, int number) {
            return (bool) interceptor.Invoke("parseLine$$", "parseLine(const QString&, int)", typeof(bool), typeof(string), line, typeof(int), number);
        }
        protected bool Parse(string str) {
            return (bool) interceptor.Invoke("parse$", "parse(const QString&)", typeof(bool), typeof(string), str);
        }
        protected void SetValid(bool arg1) {
            interceptor.Invoke("setValid$", "setValid(bool)", typeof(void), typeof(bool), arg1);
        }
    }
}
