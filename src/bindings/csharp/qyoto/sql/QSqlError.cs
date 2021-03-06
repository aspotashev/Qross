//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QSqlError")]
    public class QSqlError : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QSqlError(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSqlError), this);
        }
        public enum ErrorType {
            NoError = 0,
            ConnectionError = 1,
            StatementError = 2,
            TransactionError = 3,
            UnknownError = 4,
        }
        public QSqlError(string driverText, string databaseText, QSqlError.ErrorType type, int number) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlError$$$$", "QSqlError(const QString&, const QString&, QSqlError::ErrorType, int)", typeof(void), typeof(string), driverText, typeof(string), databaseText, typeof(QSqlError.ErrorType), type, typeof(int), number);
        }
        public QSqlError(string driverText, string databaseText, QSqlError.ErrorType type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlError$$$", "QSqlError(const QString&, const QString&, QSqlError::ErrorType)", typeof(void), typeof(string), driverText, typeof(string), databaseText, typeof(QSqlError.ErrorType), type);
        }
        public QSqlError(string driverText, string databaseText) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlError$$", "QSqlError(const QString&, const QString&)", typeof(void), typeof(string), driverText, typeof(string), databaseText);
        }
        public QSqlError(string driverText) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlError$", "QSqlError(const QString&)", typeof(void), typeof(string), driverText);
        }
        public QSqlError() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlError", "QSqlError()", typeof(void));
        }
        public QSqlError(QSqlError other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlError#", "QSqlError(const QSqlError&)", typeof(void), typeof(QSqlError), other);
        }
        public string DriverText() {
            return (string) interceptor.Invoke("driverText", "driverText() const", typeof(string));
        }
        public void SetDriverText(string driverText) {
            interceptor.Invoke("setDriverText$", "setDriverText(const QString&)", typeof(void), typeof(string), driverText);
        }
        public string DatabaseText() {
            return (string) interceptor.Invoke("databaseText", "databaseText() const", typeof(string));
        }
        public void SetDatabaseText(string databaseText) {
            interceptor.Invoke("setDatabaseText$", "setDatabaseText(const QString&)", typeof(void), typeof(string), databaseText);
        }
        public QSqlError.ErrorType type() {
            return (QSqlError.ErrorType) interceptor.Invoke("type", "type() const", typeof(QSqlError.ErrorType));
        }
        public void SetType(QSqlError.ErrorType type) {
            interceptor.Invoke("setType$", "setType(QSqlError::ErrorType)", typeof(void), typeof(QSqlError.ErrorType), type);
        }
        public int Number() {
            return (int) interceptor.Invoke("number", "number() const", typeof(int));
        }
        public void SetNumber(int number) {
            interceptor.Invoke("setNumber$", "setNumber(int)", typeof(void), typeof(int), number);
        }
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        ~QSqlError() {
            interceptor.Invoke("~QSqlError", "~QSqlError()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QSqlError", "~QSqlError()", typeof(void));
        }
    }
}
