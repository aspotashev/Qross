//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  KUrlLabel is a drop-in replacement for QLabel that handles text
    ///  in a fashion similar to how an HTML widget handles hyperlinks.  The
    ///  text can be underlined (or not) and set to different colors.  It
    ///  can also "glow" (cycle colors) when the mouse passes over it.
    ///  KUrlLabel also provides signals for several events, including
    ///  the mouse leaving and entering the text area and all forms of
    ///  mouse clicking.
    ///  By default KUrlLabel accepts focus. When focused, standard
    ///  focus rectangle is displayed as in HTML widget.
    ///  Pressing Enter key accepts the focused label.
    ///  A typical usage would be something like so:
    ///  <pre>
    ///  KUrlLabel address = new KUrlLabel(this);
    ///  address.SetText("My homepage");
    ///  address.SetUrl("http://www.home.com/~me");
    ///  connect(address, SIGNAL("leftClickedUrl(string)"),
    ///                   SLOT("processMyUrl(string)"));
    ///  </pre>
    ///  In this example, the text "My homepage" would be displayed
    ///  as blue, underlined text.  When the mouse passed over it,
    ///  it would "glow" red.  When the user clicks on the text, the
    ///  signal leftClickedUrl() would be emitted with "http://www.home.com/~me"
    ///  as its argument.
    ///  \image html kurllabel.png "KDE URL Label"
    ///  See <see cref="IKUrlLabelSignals"></see> for signals emitted by KUrlLabel
    /// </remarks>        <author> Peter Putzer <putzer@kde.org> (Rewrite)
    ///  </author>
    ///         <short> A drop-in replacement for QLabel that displays hyperlinks. </short>
    [SmokeClass("KUrlLabel")]
    public class KUrlLabel : QLabel, IDisposable {
        protected KUrlLabel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KUrlLabel), this);
        }
        [Q_PROPERTY("QString", "url")]
        public string Url {
            get { return (string) interceptor.Invoke("url", "url()", typeof(string)); }
            set { interceptor.Invoke("setUrl$", "setUrl(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "tipText")]
        public string TipText {
            get { return (string) interceptor.Invoke("tipText", "tipText()", typeof(string)); }
            set { interceptor.Invoke("setTipText$", "setTipText(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QPixmap", "alternatePixmap")]
        public QPixmap AlternatePixmap {
            get { return (QPixmap) interceptor.Invoke("alternatePixmap", "alternatePixmap()", typeof(QPixmap)); }
            set { interceptor.Invoke("setAlternatePixmap#", "setAlternatePixmap(QPixmap)", typeof(void), typeof(QPixmap), value); }
        }
        [Q_PROPERTY("bool", "glowEnabled")]
        public bool GlowEnabled {
            get { return (bool) interceptor.Invoke("isGlowEnabled", "isGlowEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setGlowEnabled$", "setGlowEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "floatEnabled")]
        public bool FloatEnabled {
            get { return (bool) interceptor.Invoke("isFloatEnabled", "isFloatEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setFloatEnabled$", "setFloatEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "useTips")]
        public bool UseTips {
            get { return (bool) interceptor.Invoke("useTips", "useTips()", typeof(bool)); }
            set { interceptor.Invoke("setUseTips$", "setUseTips(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "useCursor")]
        public bool UseCursor {
            get { return (bool) interceptor.Invoke("useCursor", "useCursor()", typeof(bool)); }
            set { interceptor.Invoke("setUseCursor$", "setUseCursor(bool)", typeof(void), typeof(bool), value); }
        }
        /// <remarks>
        ///  Default constructor.
        ///  Use setUrl() and setText() or QListView.SetPixmap()
        ///  to set the resp. properties.
        ///      </remarks>        <short>    Default constructor.</short>
        public KUrlLabel(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KUrlLabel#", "KUrlLabel(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KUrlLabel() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KUrlLabel", "KUrlLabel()", typeof(void));
        }
        /// <remarks>
        ///  Convenience constructor.
        /// <param> name="url" is the URL emitted when the label is clicked.
        /// </param><param> name="text" is the displayed string. If it's equal to string()
        ///  the <code>url</code> will be used instead.
        /// </param><param> name="parent" Passed to lower level constructor
        /// </param> <code>parent</code> and <code>name</code> are passed to QLabel, which in turn passes
        ///  them further down
        ///      </remarks>        <short>    Convenience constructor.</short>
        public KUrlLabel(string url, string text, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KUrlLabel$$#", "KUrlLabel(const QString&, const QString&, QWidget*)", typeof(void), typeof(string), url, typeof(string), text, typeof(QWidget), parent);
        }
        public KUrlLabel(string url, string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KUrlLabel$$", "KUrlLabel(const QString&, const QString&)", typeof(void), typeof(string), url, typeof(string), text);
        }
        public KUrlLabel(string url) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KUrlLabel$", "KUrlLabel(const QString&)", typeof(void), typeof(string), url);
        }
        /// <remarks>
        ///  Turns on or off the underlining.
        ///   When this is on, the
        ///  text will be underlined.  By default, it is <code>true.</code>
        ///      </remarks>        <short>    Turns on or off the underlining.</short>
        [Q_SLOT("void setUnderline(bool)")]
        public void SetUnderline(bool on) {
            interceptor.Invoke("setUnderline$", "setUnderline(bool)", typeof(void), typeof(bool), on);
        }
        [Q_SLOT("void setUnderline()")]
        public void SetUnderline() {
            interceptor.Invoke("setUnderline", "setUnderline()", typeof(void));
        }
        /// <remarks>
        ///  Sets the URL for this label to <code>url.</code>
        /// </remarks>        <short>    Sets the URL for this label to <code>url.</code></short>
        ///         <see> url</see>
        [Q_SLOT("void setUrl(QString)")]
        public void SetUrl(string url) {
            interceptor.Invoke("setUrl$", "setUrl(const QString&)", typeof(void), typeof(string), url);
        }
        /// <remarks>
        ///  Overridden for internal reasons; the API remains unaffected.
        ///      </remarks>        <short>    Overridden for internal reasons; the API remains unaffected.</short>
        [Q_SLOT("void setFont(QFont)")]
        [SmokeMethod("setFont(const QFont&)")]
        public virtual void SetFont(QFont font) {
            interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
        }
        /// <remarks>
        ///  Turns on or off the tool tip feature.
        ///  When this is on, the URL will be displayed as a
        ///  tooltip whenever the mouse passes passes over it.
        ///  By default, it is <code>false.</code>
        ///      </remarks>        <short>    Turns on or off the tool tip feature.</short>
        [Q_SLOT("void setUseTips(bool)")]
        public void SetUseTips(bool on) {
            interceptor.Invoke("setUseTips$", "setUseTips(bool)", typeof(void), typeof(bool), on);
        }
        [Q_SLOT("void setUseTips()")]
        public void SetUseTips() {
            interceptor.Invoke("setUseTips", "setUseTips()", typeof(void));
        }
        /// <remarks>
        ///  Specifies what text to display when tooltips are turned on.
        ///  If this is not used, the tip will default to the URL.
        /// </remarks>        <short>    Specifies what text to display when tooltips are turned on.</short>
        ///         <see> setUseTips</see>
        [Q_SLOT("void setTipText(QString)")]
        public void SetTipText(string tip) {
            interceptor.Invoke("setTipText$", "setTipText(const QString&)", typeof(void), typeof(string), tip);
        }
        /// <remarks>
        ///  Sets the highlight color.
        ///  This is the default foreground
        ///  color (non-selected).  By default, it is <code>blue.</code>
        ///      </remarks>        <short>    Sets the highlight color.</short>
        [Q_SLOT("void setHighlightedColor(QColor)")]
        public void SetHighlightedColor(QColor highcolor) {
            interceptor.Invoke("setHighlightedColor#", "setHighlightedColor(const QColor&)", typeof(void), typeof(QColor), highcolor);
        }
        /// <remarks>
        ///  This is an overloaded version for convenience.
        /// </remarks>        <short>    This is an overloaded version for convenience.</short>
        ///         <see> setHighlightedColor</see>
        [Q_SLOT("void setHighlightedColor(QString)")]
        public void SetHighlightedColor(string highcolor) {
            interceptor.Invoke("setHighlightedColor$", "setHighlightedColor(const QString&)", typeof(void), typeof(string), highcolor);
        }
        /// <remarks>
        ///  Sets the selected color.
        ///  This is the color the text will change
        ///  to when either a mouse passes over it and "glow" mode is on or
        ///  when it is selected (clicked).  By default, it is <code>red.</code>
        ///      </remarks>        <short>    Sets the selected color.</short>
        [Q_SLOT("void setSelectedColor(QColor)")]
        public void SetSelectedColor(QColor color) {
            interceptor.Invoke("setSelectedColor#", "setSelectedColor(const QColor&)", typeof(void), typeof(QColor), color);
        }
        /// <remarks>
        ///  This is an overloaded version for convenience.
        /// </remarks>        <short>    This is an overloaded version for convenience.</short>
        ///         <see> setSelectedColor</see>
        [Q_SLOT("void setSelectedColor(QString)")]
        public void SetSelectedColor(string color) {
            interceptor.Invoke("setSelectedColor$", "setSelectedColor(const QString&)", typeof(void), typeof(string), color);
        }
        /// <remarks>
        ///  Turns the custom cursor feature on or off.
        ///  When this is on, the cursor will change to a custom cursor
        ///  (default is a "pointing hand") whenever the cursor passes
        ///  over the label. By default, it is on.
        /// <param> name="on" whether a custom cursor should be displayed.
        /// </param><param> name="cursor" is the custom cursor. <code>null</code> indicates the default "hand cursor".
        ///      </param></remarks>        <short>    Turns the custom cursor feature on or off.</short>
        [Q_SLOT("void setUseCursor(bool, QCursor*)")]
        public void SetUseCursor(bool on, QCursor cursor) {
            interceptor.Invoke("setUseCursor$#", "setUseCursor(bool, QCursor*)", typeof(void), typeof(bool), on, typeof(QCursor), cursor);
        }
        [Q_SLOT("void setUseCursor(bool)")]
        public void SetUseCursor(bool on) {
            interceptor.Invoke("setUseCursor$", "setUseCursor(bool)", typeof(void), typeof(bool), on);
        }
        /// <remarks>
        ///  Turns on or off the "glow" feature.
        ///  When this is on, the text will switch to the
        ///  selected color whenever the mouse
        ///  passes over it. By default, it is <code>true.</code>
        ///      </remarks>        <short>    Turns on or off the "glow" feature.</short>
        [Q_SLOT("void setGlowEnabled(bool)")]
        public void SetGlowEnabled(bool glow) {
            interceptor.Invoke("setGlowEnabled$", "setGlowEnabled(bool)", typeof(void), typeof(bool), glow);
        }
        [Q_SLOT("void setGlowEnabled()")]
        public void SetGlowEnabled() {
            interceptor.Invoke("setGlowEnabled", "setGlowEnabled()", typeof(void));
        }
        /// <remarks>
        ///  Turns on or off the "float" feature.
        ///  This feature is very similar to the "glow" feature in
        ///  that the color of the label switches to the selected
        ///  color when the cursor passes over it. In addition,
        ///  underlining is turned on for as long as the mouse is overhead.
        ///  Note that if "glow" and underlining are both already turned
        ///  on, this feature will have no visible effect.
        ///  By default, it is <code>false.</code>
        ///      </remarks>        <short>    Turns on or off the "float" feature.</short>
        [Q_SLOT("void setFloatEnabled(bool)")]
        public void SetFloatEnabled(bool do_float) {
            interceptor.Invoke("setFloatEnabled$", "setFloatEnabled(bool)", typeof(void), typeof(bool), do_float);
        }
        [Q_SLOT("void setFloatEnabled()")]
        public void SetFloatEnabled() {
            interceptor.Invoke("setFloatEnabled", "setFloatEnabled()", typeof(void));
        }
        /// <remarks>
        ///  Sets the "alt" pixmap.
        ///  This pixmap will be displayed when the
        ///  cursor passes over the label.  The effect is similar to the
        ///  trick done with 'onMouseOver' in javascript.
        /// </remarks>        <short>    Sets the "alt" pixmap.</short>
        ///         <see> alternatePixmap</see>
        [Q_SLOT("void setAlternatePixmap(QPixmap)")]
        public void SetAlternatePixmap(QPixmap pixmap) {
            interceptor.Invoke("setAlternatePixmap#", "setAlternatePixmap(const QPixmap&)", typeof(void), typeof(QPixmap), pixmap);
        }
        /// <remarks>
        ///  Overridden for internal reasons; the API remains unaffected.
        ///      </remarks>        <short>    Overridden for internal reasons; the API remains unaffected.</short>
        [SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
        protected override void MouseReleaseEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        /// <remarks>
        ///  Overridden for internal reasons; the API remains unaffected.
        ///      </remarks>        <short>    Overridden for internal reasons; the API remains unaffected.</short>
        [SmokeMethod("enterEvent(QEvent*)")]
        protected override void EnterEvent(QEvent arg1) {
            interceptor.Invoke("enterEvent#", "enterEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        /// <remarks>
        ///  Overridden for internal reasons; the API remains unaffected.
        ///      </remarks>        <short>    Overridden for internal reasons; the API remains unaffected.</short>
        [SmokeMethod("leaveEvent(QEvent*)")]
        protected override void LeaveEvent(QEvent arg1) {
            interceptor.Invoke("leaveEvent#", "leaveEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        /// <remarks>
        ///  Catch parent palette changes
        ///      </remarks>        <short>    Catch parent palette changes      </short>
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        ~KUrlLabel() {
            interceptor.Invoke("~KUrlLabel", "~KUrlLabel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KUrlLabel", "~KUrlLabel()", typeof(void));
        }
        protected new IKUrlLabelSignals Emit {
            get { return (IKUrlLabelSignals) Q_EMIT; }
        }
    }

    public interface IKUrlLabelSignals : IQLabelSignals {
        /// <remarks>
        ///  Emitted when the mouse has passed over the label.
        /// <param> name="url" The URL for this label.
        ///      </param></remarks>        <short>    Emitted when the mouse has passed over the label.</short>
        [Q_SIGNAL("void enteredUrl(QString)")]
        void EnteredUrl(string url);
        /// <remarks>
        ///  Emitted when the mouse has passed over the label.
        ///      </remarks>        <short>    Emitted when the mouse has passed over the label.</short>
        [Q_SIGNAL("void enteredUrl()")]
        void EnteredUrl();
        /// <remarks>
        ///  Emitted when the mouse is no longer over the label.
        /// <param> name="url" The URL for this label.
        ///      </param></remarks>        <short>    Emitted when the mouse is no longer over the label.</short>
        [Q_SIGNAL("void leftUrl(QString)")]
        void LeftUrl(string url);
        /// <remarks>
        ///  Emitted when the mouse is no longer over the label.
        ///      </remarks>        <short>    Emitted when the mouse is no longer over the label.</short>
        [Q_SIGNAL("void leftUrl()")]
        void LeftUrl();
        /// <remarks>
        ///  Emitted when the user clicked the left mouse button on this label.
        /// <param> name="url" The URL for this label.
        ///      </param></remarks>        <short>    Emitted when the user clicked the left mouse button on this label.</short>
        [Q_SIGNAL("void leftClickedUrl(QString)")]
        void LeftClickedUrl(string url);
        /// <remarks>
        ///  Emitted when the user clicked the left mouse button on this label.
        ///      </remarks>        <short>    Emitted when the user clicked the left mouse button on this label.</short>
        [Q_SIGNAL("void leftClickedUrl()")]
        void LeftClickedUrl();
        /// <remarks>
        ///  Emitted when the user clicked the right mouse button on this label.
        /// <param> name="url" The URL for this label.
        ///      </param></remarks>        <short>    Emitted when the user clicked the right mouse button on this label.</short>
        [Q_SIGNAL("void rightClickedUrl(QString)")]
        void RightClickedUrl(string url);
        /// <remarks>
        ///  Emitted when the user clicked the right mouse button on this label.
        ///      </remarks>        <short>    Emitted when the user clicked the right mouse button on this label.</short>
        [Q_SIGNAL("void rightClickedUrl()")]
        void RightClickedUrl();
        /// <remarks>
        ///  Emitted when the user clicked the middle mouse button on this label.
        /// <param> name="url" The URL for this label.
        ///      </param></remarks>        <short>    Emitted when the user clicked the middle mouse button on this label.</short>
        [Q_SIGNAL("void middleClickedUrl(QString)")]
        void MiddleClickedUrl(string url);
        /// <remarks>
        ///  Emitted when the user clicked the left mouse button on this label.
        ///      </remarks>        <short>    Emitted when the user clicked the left mouse button on this label.</short>
        [Q_SIGNAL("void middleClickedUrl()")]
        void MiddleClickedUrl();
    }
}
