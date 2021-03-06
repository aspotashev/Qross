//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  A container widget which arranges its children horizontally.
    ///  When using a KHBox you don't need to create a layout nor
    ///  to add the child widgets to it.
    /// </remarks>        <short>    A container widget which arranges its children horizontally.</short>
    ///         <see> KVBox</see>
    [SmokeClass("KHBox")]
    public class KHBox : QFrame, IDisposable {
        protected KHBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KHBox), this);
        }
        /// <remarks>
        ///  Creates a new hbox.
        ///      </remarks>        <short>    Creates a new hbox.</short>
        public KHBox(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHBox#", "KHBox(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KHBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHBox", "KHBox()", typeof(void));
        }
        /// <remarks>
        ///  Sets the <code>margin</code> of the hbox.
        ///      </remarks>        <short>    Sets the <code>margin</code> of the hbox.</short>
        public void SetMargin(int margin) {
            interceptor.Invoke("setMargin$", "setMargin(int)", typeof(void), typeof(int), margin);
        }
        /// <remarks>
        ///  Sets the spacing between the child widgets to <code>space</code>
        ///      </remarks>        <short>    Sets the spacing between the child widgets to <code>space</code>      </short>
        public void SetSpacing(int space) {
            interceptor.Invoke("setSpacing$", "setSpacing(int)", typeof(void), typeof(int), space);
        }
        public void SetStretchFactor(QWidget widget, int stretch) {
            interceptor.Invoke("setStretchFactor#$", "setStretchFactor(QWidget*, int)", typeof(void), typeof(QWidget), widget, typeof(int), stretch);
        }
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        [SmokeMethod("minimumSizeHint() const")]
        public override QSize MinimumSizeHint() {
            return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
        }
        public KHBox(bool vertical, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHBox$#", "KHBox(bool, QWidget*)", typeof(void), typeof(bool), vertical, typeof(QWidget), parent);
        }
        [SmokeMethod("childEvent(QChildEvent*)")]
        protected override void ChildEvent(QChildEvent ev) {
            interceptor.Invoke("childEvent#", "childEvent(QChildEvent*)", typeof(void), typeof(QChildEvent), ev);
        }
        ~KHBox() {
            interceptor.Invoke("~KHBox", "~KHBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KHBox", "~KHBox()", typeof(void));
        }
        protected new IKHBoxSignals Emit {
            get { return (IKHBoxSignals) Q_EMIT; }
        }
    }

    public interface IKHBoxSignals : IQFrameSignals {
    }
}
