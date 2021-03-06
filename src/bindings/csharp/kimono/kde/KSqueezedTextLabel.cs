//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  A label class that squeezes its text into the label
    ///  If the text is too long to fit into the label it is divided into
    ///  remaining left and right parts which are separated by three dots.
    ///  Example:
    ///  http://www.kde.org/documentation/index.html could be squeezed to
    ///  http://www.kde...ion/index.html
    ///  \image html ksqueezedtextlabel.png "KSqueezedTextLabel Widget"
    /// </remarks>        <author> Ronny Standtke <Ronny.Standtke@gmx.de>
    ///  </author>
    ///         <short> A replacement for QLabel that squeezes its text.</short>
    [SmokeClass("KSqueezedTextLabel")]
    public class KSqueezedTextLabel : QLabel, IDisposable {
        protected KSqueezedTextLabel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KSqueezedTextLabel), this);
        }
        [Q_PROPERTY("Qt::TextElideMode", "textElideMode")]
        public new Qt.TextElideMode TextElideMode {
            get { return (Qt.TextElideMode) interceptor.Invoke("textElideMode", "textElideMode()", typeof(Qt.TextElideMode)); }
            set { interceptor.Invoke("setTextElideMode$", "setTextElideMode(Qt::TextElideMode)", typeof(void), typeof(Qt.TextElideMode), value); }
        }
        /// <remarks>
        ///  Default constructor.
        ///    </remarks>        <short>    Default constructor.</short>
        public KSqueezedTextLabel(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KSqueezedTextLabel#", "KSqueezedTextLabel(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KSqueezedTextLabel() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KSqueezedTextLabel", "KSqueezedTextLabel()", typeof(void));
        }
        public KSqueezedTextLabel(string text, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KSqueezedTextLabel$#", "KSqueezedTextLabel(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
        }
        public KSqueezedTextLabel(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KSqueezedTextLabel$", "KSqueezedTextLabel(const QString&)", typeof(void), typeof(string), text);
        }
        [SmokeMethod("minimumSizeHint() const")]
        public override QSize MinimumSizeHint() {
            return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
        }
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        /// <remarks>
        ///  Overridden for internal reasons; the API remains unaffected.
        ///    </remarks>        <short>    Overridden for internal reasons; the API remains unaffected.</short>
        [SmokeMethod("setAlignment(Qt::Alignment)")]
        public virtual void SetAlignment(uint arg1) {
            interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(uint), arg1);
        }
        /// <remarks>
        ///  Sets the text. Note that this is not technically a reimplementation of QLabel.SetText(),
        ///  which is not (in Qt 4.3). Therefore, you may need to cast the object to
        ///  KSqueezedTextLabel in some situations:
        ///  \Example
        ///  <pre>
        ///  KSqueezedTextLabel squeezed = new KSqueezedTextLabel("text", parent);
        ///  QLabel label = squeezed;
        ///  label.SetText("new text");	// this will not work
        ///  squeezed.SetText("new text");	// works as expected
        ///  (KSqueezedTextLabel)(label).SetText("new text");	// works as expected
        ///  </pre>
        /// <param> name="mode" The new text.
        ///    </param></remarks>        <short>    Sets the text.</short>
        [Q_SLOT("void setText(QString)")]
        public void SetText(string text) {
            interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
        }
        /// <remarks>
        ///  Called when widget is resized
        ///    </remarks>        <short>    Called when widget is resized    </short>
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
        }
        /// <remarks>
        ///  \reimp
        ///      </remarks>        <short>    \reimp      </short>
        [SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
        protected override void ContextMenuEvent(QContextMenuEvent arg1) {
            interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
        }
        /// <remarks>
        ///  does the dirty work
        ///    </remarks>        <short>    does the dirty work    </short>
        protected void SqueezeTextToLabel() {
            interceptor.Invoke("squeezeTextToLabel", "squeezeTextToLabel()", typeof(void));
        }
        ~KSqueezedTextLabel() {
            interceptor.Invoke("~KSqueezedTextLabel", "~KSqueezedTextLabel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KSqueezedTextLabel", "~KSqueezedTextLabel()", typeof(void));
        }
        protected new IKSqueezedTextLabelSignals Emit {
            get { return (IKSqueezedTextLabelSignals) Q_EMIT; }
        }
    }

    public interface IKSqueezedTextLabelSignals : IQLabelSignals {
    }
}
