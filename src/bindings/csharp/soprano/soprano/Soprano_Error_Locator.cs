//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Error {
    using Soprano;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \class Locator locator.h Soprano/Error/Locator
    ///  \brief Details of a parser Error
    ///  A Locator object provides additional information about
    ///  parsing errors.
    ///          </remarks>        <short>    \class Locator locator.</short>
    [SmokeClass("Soprano::Error::Locator")]
    public class Locator : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected Locator(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Locator), this);
        }
        public Locator() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Locator", "Locator()", typeof(void));
        }
        public Locator(int line, int column, int arg3, string filename) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Locator$$$$", "Locator(int, int, int, const QString&)", typeof(void), typeof(int), line, typeof(int), column, typeof(int), arg3, typeof(string), filename);
        }
        public Locator(int line, int column, int arg3) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Locator$$$", "Locator(int, int, int)", typeof(void), typeof(int), line, typeof(int), column, typeof(int), arg3);
        }
        public Locator(int line, int column) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Locator$$", "Locator(int, int)", typeof(void), typeof(int), line, typeof(int), column);
        }
        public Locator(Soprano.Error.Locator other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Locator#", "Locator(const Soprano::Error::Locator&)", typeof(void), typeof(Soprano.Error.Locator), other);
        }
        public int Line() {
            return (int) interceptor.Invoke("line", "line() const", typeof(int));
        }
        public int Column() {
            return (int) interceptor.Invoke("column", "column() const", typeof(int));
        }
        public int Byte() {
            return (int) interceptor.Invoke("byte", "byte() const", typeof(int));
        }
        public string FileName() {
            return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
        }
        public void SetLine(int line) {
            interceptor.Invoke("setLine$", "setLine(int)", typeof(void), typeof(int), line);
        }
        public void SetColumn(int column) {
            interceptor.Invoke("setColumn$", "setColumn(int)", typeof(void), typeof(int), column);
        }
        public void SetByte(int arg1) {
            interceptor.Invoke("setByte$", "setByte(int)", typeof(void), typeof(int), arg1);
        }
        public void SetFileName(string fileName) {
            interceptor.Invoke("setFileName$", "setFileName(const QString&)", typeof(void), typeof(string), fileName);
        }
        ~Locator() {
            interceptor.Invoke("~Locator", "~Locator()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~Locator", "~Locator()", typeof(void));
        }
    }
}
