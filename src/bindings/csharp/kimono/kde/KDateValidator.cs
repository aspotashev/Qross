//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Runtime.InteropServices;
    using System.Text;
    /// <remarks>
    ///  Validates user-entered dates.
    /// </remarks>        <short>    Validates user-entered dates.</short>
    [SmokeClass("KDateValidator")]
    public class KDateValidator : QValidator, IDisposable {
        protected KDateValidator(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KDateValidator), this);
        }
        public KDateValidator(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDateValidator#", "KDateValidator(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KDateValidator() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDateValidator", "KDateValidator()", typeof(void));
        }
        [SmokeMethod("validate(QString&, int&) const")]
        public override QValidator.State Validate(StringBuilder text, ref int e) {
            StackItem[] stack = new StackItem[3];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(text);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(text);
#endif
            stack[2].s_int = e;
            interceptor.Invoke("validate$$", "validate(QString&, int&) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
            e = stack[2].s_int;
            return (QValidator.State) Enum.ToObject(typeof(QValidator.State), stack[0].s_int);
        }
        [SmokeMethod("fixup(QString&) const")]
        public override void Fixup(StringBuilder input) {
            interceptor.Invoke("fixup$", "fixup(QString&) const", typeof(void), typeof(StringBuilder), input);
        }
        public QValidator.State Date(string text, QDate date) {
            return (QValidator.State) interceptor.Invoke("date$#", "date(const QString&, QDate&) const", typeof(QValidator.State), typeof(string), text, typeof(QDate), date);
        }
        ~KDateValidator() {
            interceptor.Invoke("~KDateValidator", "~KDateValidator()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KDateValidator", "~KDateValidator()", typeof(void));
        }
        protected new IKDateValidatorSignals Emit {
            get { return (IKDateValidatorSignals) Q_EMIT; }
        }
    }

    public interface IKDateValidatorSignals : IQValidatorSignals {
    }
}
