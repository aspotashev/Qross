//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QSqlResult")]
    public abstract class QSqlResult : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QSqlResult(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSqlResult), this);
        }
        public enum BindingSyntax {
            PositionalBinding = 0,
            NamedBinding = 1,
        }
        public enum VirtualHookOperation {
            BatchOperation = 0,
            DetachFromResultSet = 1,
            SetNumericalPrecision = 2,
            NextResult = 3,
        }
        public QSqlResult(QSqlDriver db) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlResult#", "QSqlResult(const QSqlDriver*)", typeof(void), typeof(QSqlDriver), db);
        }
        protected int At() {
            return (int) interceptor.Invoke("at", "at() const", typeof(int));
        }
        protected string LastQuery() {
            return (string) interceptor.Invoke("lastQuery", "lastQuery() const", typeof(string));
        }
        protected QSqlError LastError() {
            return (QSqlError) interceptor.Invoke("lastError", "lastError() const", typeof(QSqlError));
        }
        protected bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        protected bool IsActive() {
            return (bool) interceptor.Invoke("isActive", "isActive() const", typeof(bool));
        }
        protected bool IsSelect() {
            return (bool) interceptor.Invoke("isSelect", "isSelect() const", typeof(bool));
        }
        protected bool IsForwardOnly() {
            return (bool) interceptor.Invoke("isForwardOnly", "isForwardOnly() const", typeof(bool));
        }
        protected QSqlDriver Driver() {
            return (QSqlDriver) interceptor.Invoke("driver", "driver() const", typeof(QSqlDriver));
        }
        [SmokeMethod("setAt(int)")]
        protected virtual void SetAt(int at) {
            interceptor.Invoke("setAt$", "setAt(int)", typeof(void), typeof(int), at);
        }
        [SmokeMethod("setActive(bool)")]
        protected virtual void SetActive(bool a) {
            interceptor.Invoke("setActive$", "setActive(bool)", typeof(void), typeof(bool), a);
        }
        [SmokeMethod("setLastError(const QSqlError&)")]
        protected virtual void SetLastError(QSqlError e) {
            interceptor.Invoke("setLastError#", "setLastError(const QSqlError&)", typeof(void), typeof(QSqlError), e);
        }
        [SmokeMethod("setQuery(const QString&)")]
        protected virtual void SetQuery(string query) {
            interceptor.Invoke("setQuery$", "setQuery(const QString&)", typeof(void), typeof(string), query);
        }
        [SmokeMethod("setSelect(bool)")]
        protected virtual void SetSelect(bool s) {
            interceptor.Invoke("setSelect$", "setSelect(bool)", typeof(void), typeof(bool), s);
        }
        [SmokeMethod("setForwardOnly(bool)")]
        protected virtual void SetForwardOnly(bool forward) {
            interceptor.Invoke("setForwardOnly$", "setForwardOnly(bool)", typeof(void), typeof(bool), forward);
        }
        [SmokeMethod("exec()")]
        protected virtual bool Exec() {
            return (bool) interceptor.Invoke("exec", "exec()", typeof(bool));
        }
        [SmokeMethod("prepare(const QString&)")]
        protected virtual bool Prepare(string query) {
            return (bool) interceptor.Invoke("prepare$", "prepare(const QString&)", typeof(bool), typeof(string), query);
        }
        [SmokeMethod("savePrepare(const QString&)")]
        protected virtual bool SavePrepare(string sqlquery) {
            return (bool) interceptor.Invoke("savePrepare$", "savePrepare(const QString&)", typeof(bool), typeof(string), sqlquery);
        }
        [SmokeMethod("bindValue(int, const QVariant&, QSql::ParamType)")]
        protected virtual void BindValue(int pos, QVariant val, uint type) {
            interceptor.Invoke("bindValue$#$", "bindValue(int, const QVariant&, QSql::ParamType)", typeof(void), typeof(int), pos, typeof(QVariant), val, typeof(uint), type);
        }
        [SmokeMethod("bindValue(const QString&, const QVariant&, QSql::ParamType)")]
        protected virtual void BindValue(string placeholder, QVariant val, uint type) {
            interceptor.Invoke("bindValue$#$", "bindValue(const QString&, const QVariant&, QSql::ParamType)", typeof(void), typeof(string), placeholder, typeof(QVariant), val, typeof(uint), type);
        }
        protected void AddBindValue(QVariant val, uint type) {
            interceptor.Invoke("addBindValue#$", "addBindValue(const QVariant&, QSql::ParamType)", typeof(void), typeof(QVariant), val, typeof(uint), type);
        }
        protected QVariant BoundValue(string placeholder) {
            return (QVariant) interceptor.Invoke("boundValue$", "boundValue(const QString&) const", typeof(QVariant), typeof(string), placeholder);
        }
        protected QVariant BoundValue(int pos) {
            return (QVariant) interceptor.Invoke("boundValue$", "boundValue(int) const", typeof(QVariant), typeof(int), pos);
        }
        protected uint BindValueType(string placeholder) {
            return (uint) interceptor.Invoke("bindValueType$", "bindValueType(const QString&) const", typeof(uint), typeof(string), placeholder);
        }
        protected uint BindValueType(int pos) {
            return (uint) interceptor.Invoke("bindValueType$", "bindValueType(int) const", typeof(uint), typeof(int), pos);
        }
        protected int BoundValueCount() {
            return (int) interceptor.Invoke("boundValueCount", "boundValueCount() const", typeof(int));
        }
        protected List<QVariant> BoundValues() {
            return (List<QVariant>) interceptor.Invoke("boundValues", "boundValues() const", typeof(List<QVariant>));
        }
        protected string ExecutedQuery() {
            return (string) interceptor.Invoke("executedQuery", "executedQuery() const", typeof(string));
        }
        protected string BoundValueName(int pos) {
            return (string) interceptor.Invoke("boundValueName$", "boundValueName(int) const", typeof(string), typeof(int), pos);
        }
        protected void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        protected bool HasOutValues() {
            return (bool) interceptor.Invoke("hasOutValues", "hasOutValues() const", typeof(bool));
        }
        protected QSqlResult.BindingSyntax bindingSyntax() {
            return (QSqlResult.BindingSyntax) interceptor.Invoke("bindingSyntax", "bindingSyntax() const", typeof(QSqlResult.BindingSyntax));
        }
        [SmokeMethod("data(int)")]
        protected abstract QVariant Data(int i);
        [SmokeMethod("isNull(int)")]
        protected abstract bool IsNull(int i);
        [SmokeMethod("reset(const QString&)")]
        protected abstract bool Reset(string sqlquery);
        [SmokeMethod("fetch(int)")]
        protected abstract bool Fetch(int i);
        [SmokeMethod("fetchNext()")]
        protected virtual bool FetchNext() {
            return (bool) interceptor.Invoke("fetchNext", "fetchNext()", typeof(bool));
        }
        [SmokeMethod("fetchPrevious()")]
        protected virtual bool FetchPrevious() {
            return (bool) interceptor.Invoke("fetchPrevious", "fetchPrevious()", typeof(bool));
        }
        [SmokeMethod("fetchFirst()")]
        protected abstract bool FetchFirst();
        [SmokeMethod("fetchLast()")]
        protected abstract bool FetchLast();
        [SmokeMethod("size()")]
        protected abstract int Size();
        [SmokeMethod("numRowsAffected()")]
        protected abstract int NumRowsAffected();
        [SmokeMethod("record() const")]
        protected virtual QSqlRecord Record() {
            return (QSqlRecord) interceptor.Invoke("record", "record() const", typeof(QSqlRecord));
        }
        [SmokeMethod("lastInsertId() const")]
        protected virtual QVariant LastInsertId() {
            return (QVariant) interceptor.Invoke("lastInsertId", "lastInsertId() const", typeof(QVariant));
        }
        protected bool ExecBatch(bool arrayBind) {
            return (bool) interceptor.Invoke("execBatch$", "execBatch(bool)", typeof(bool), typeof(bool), arrayBind);
        }
        protected bool ExecBatch() {
            return (bool) interceptor.Invoke("execBatch", "execBatch()", typeof(bool));
        }
        protected void DetachFromResultSet() {
            interceptor.Invoke("detachFromResultSet", "detachFromResultSet()", typeof(void));
        }
        protected void SetNumericalPrecisionPolicy(QSql.NumericalPrecisionPolicy policy) {
            interceptor.Invoke("setNumericalPrecisionPolicy$", "setNumericalPrecisionPolicy(QSql::NumericalPrecisionPolicy)", typeof(void), typeof(QSql.NumericalPrecisionPolicy), policy);
        }
        protected QSql.NumericalPrecisionPolicy NumericalPrecisionPolicy() {
            return (QSql.NumericalPrecisionPolicy) interceptor.Invoke("numericalPrecisionPolicy", "numericalPrecisionPolicy() const", typeof(QSql.NumericalPrecisionPolicy));
        }
        protected bool NextResult() {
            return (bool) interceptor.Invoke("nextResult", "nextResult()", typeof(bool));
        }
    }
}
