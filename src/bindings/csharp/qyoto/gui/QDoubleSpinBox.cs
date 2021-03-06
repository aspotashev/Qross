//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    /// <remarks> See <see cref="IQDoubleSpinBoxSignals"></see> for signals emitted by QDoubleSpinBox
    /// </remarks>
    [SmokeClass("QDoubleSpinBox")]
    public class QDoubleSpinBox : QAbstractSpinBox, IDisposable {
        protected QDoubleSpinBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDoubleSpinBox), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QDoubleSpinBox() {
            staticInterceptor = new SmokeInvocation(typeof(QDoubleSpinBox), null);
        }
        [Q_PROPERTY("QString", "prefix")]
        public string Prefix {
            get { return (string) interceptor.Invoke("prefix", "prefix()", typeof(string)); }
            set { interceptor.Invoke("setPrefix$", "setPrefix(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "suffix")]
        public string Suffix {
            get { return (string) interceptor.Invoke("suffix", "suffix()", typeof(string)); }
            set { interceptor.Invoke("setSuffix$", "setSuffix(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "cleanText")]
        public string CleanText {
            get { return (string) interceptor.Invoke("cleanText", "cleanText()", typeof(string)); }
        }
        [Q_PROPERTY("int", "decimals")]
        public int Decimals {
            get { return (int) interceptor.Invoke("decimals", "decimals()", typeof(int)); }
            set { interceptor.Invoke("setDecimals$", "setDecimals(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("double", "minimum")]
        public double Minimum {
            get { return (double) interceptor.Invoke("minimum", "minimum()", typeof(double)); }
            set { interceptor.Invoke("setMinimum$", "setMinimum(double)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("double", "maximum")]
        public double Maximum {
            get { return (double) interceptor.Invoke("maximum", "maximum()", typeof(double)); }
            set { interceptor.Invoke("setMaximum$", "setMaximum(double)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("double", "singleStep")]
        public double SingleStep {
            get { return (double) interceptor.Invoke("singleStep", "singleStep()", typeof(double)); }
            set { interceptor.Invoke("setSingleStep$", "setSingleStep(double)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("double", "value")]
        public double Value {
            get { return (double) interceptor.Invoke("value", "value()", typeof(double)); }
            set { interceptor.Invoke("setValue$", "setValue(double)", typeof(void), typeof(double), value); }
        }
        public QDoubleSpinBox(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDoubleSpinBox#", "QDoubleSpinBox(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QDoubleSpinBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDoubleSpinBox", "QDoubleSpinBox()", typeof(void));
        }
        public void SetRange(double min, double max) {
            interceptor.Invoke("setRange$$", "setRange(double, double)", typeof(void), typeof(double), min, typeof(double), max);
        }
        [SmokeMethod("validate(QString&, int&) const")]
        public override QValidator.State Validate(StringBuilder input, ref int pos) {
            StackItem[] stack = new StackItem[3];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(input);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(input);
#endif
            stack[2].s_int = pos;
            interceptor.Invoke("validate$$", "validate(QString&, int&) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
            pos = stack[2].s_int;
            return (QValidator.State) Enum.ToObject(typeof(QValidator.State), stack[0].s_int);
        }
        [SmokeMethod("valueFromText(const QString&) const")]
        public virtual double ValueFromText(string text) {
            return (double) interceptor.Invoke("valueFromText$", "valueFromText(const QString&) const", typeof(double), typeof(string), text);
        }
        [SmokeMethod("textFromValue(double) const")]
        public virtual string TextFromValue(double val) {
            return (string) interceptor.Invoke("textFromValue$", "textFromValue(double) const", typeof(string), typeof(double), val);
        }
        [SmokeMethod("fixup(QString&) const")]
        public override void Fixup(StringBuilder str) {
            interceptor.Invoke("fixup$", "fixup(QString&) const", typeof(void), typeof(StringBuilder), str);
        }
        [Q_SLOT("void setValue(double)")]
        public void SetValue(double val) {
            interceptor.Invoke("setValue$", "setValue(double)", typeof(void), typeof(double), val);
        }
        ~QDoubleSpinBox() {
            interceptor.Invoke("~QDoubleSpinBox", "~QDoubleSpinBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDoubleSpinBox", "~QDoubleSpinBox()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQDoubleSpinBoxSignals Emit {
            get { return (IQDoubleSpinBoxSignals) Q_EMIT; }
        }
    }

    public interface IQDoubleSpinBoxSignals : IQAbstractSpinBoxSignals {
        [Q_SIGNAL("void valueChanged(double)")]
        void ValueChanged(double arg1);
        [Q_SIGNAL("void valueChanged(QString)")]
        void ValueChanged(string arg1);
    }
}
