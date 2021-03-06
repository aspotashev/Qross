//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQGraphicsTextItemSignals"></see> for signals emitted by QGraphicsTextItem
    /// </remarks>
    [SmokeClass("QGraphicsTextItem")]
    public class QGraphicsTextItem : QGraphicsObject, IDisposable {
        protected QGraphicsTextItem(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGraphicsTextItem), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QGraphicsTextItem() {
            staticInterceptor = new SmokeInvocation(typeof(QGraphicsTextItem), null);
        }
        public const int Type = 8;
        [Q_PROPERTY("bool", "openExternalLinks")]
        public bool OpenExternalLinks {
            get { return (bool) interceptor.Invoke("openExternalLinks", "openExternalLinks()", typeof(bool)); }
            set { interceptor.Invoke("setOpenExternalLinks$", "setOpenExternalLinks(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QTextCursor", "textCursor")]
        public QTextCursor TextCursor {
            get { return (QTextCursor) interceptor.Invoke("textCursor", "textCursor()", typeof(QTextCursor)); }
            set { interceptor.Invoke("setTextCursor#", "setTextCursor(QTextCursor)", typeof(void), typeof(QTextCursor), value); }
        }
        public QGraphicsTextItem(IQGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsTextItem##", "QGraphicsTextItem(QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(IQGraphicsItem), parent, typeof(QGraphicsScene), scene);
        }
        public QGraphicsTextItem(IQGraphicsItem parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsTextItem#", "QGraphicsTextItem(QGraphicsItem*)", typeof(void), typeof(IQGraphicsItem), parent);
        }
        public QGraphicsTextItem() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsTextItem", "QGraphicsTextItem()", typeof(void));
        }
        public QGraphicsTextItem(string text, IQGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsTextItem$##", "QGraphicsTextItem(const QString&, QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(string), text, typeof(IQGraphicsItem), parent, typeof(QGraphicsScene), scene);
        }
        public QGraphicsTextItem(string text, IQGraphicsItem parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsTextItem$#", "QGraphicsTextItem(const QString&, QGraphicsItem*)", typeof(void), typeof(string), text, typeof(IQGraphicsItem), parent);
        }
        public QGraphicsTextItem(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsTextItem$", "QGraphicsTextItem(const QString&)", typeof(void), typeof(string), text);
        }
        public string ToHtml() {
            return (string) interceptor.Invoke("toHtml", "toHtml() const", typeof(string));
        }
        public void SetHtml(string html) {
            interceptor.Invoke("setHtml$", "setHtml(const QString&)", typeof(void), typeof(string), html);
        }
        public string ToPlainText() {
            return (string) interceptor.Invoke("toPlainText", "toPlainText() const", typeof(string));
        }
        public void SetPlainText(string text) {
            interceptor.Invoke("setPlainText$", "setPlainText(const QString&)", typeof(void), typeof(string), text);
        }
        public QFont Font() {
            return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
        }
        public void SetFont(QFont font) {
            interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
        }
        public void SetDefaultTextColor(QColor c) {
            interceptor.Invoke("setDefaultTextColor#", "setDefaultTextColor(const QColor&)", typeof(void), typeof(QColor), c);
        }
        public QColor DefaultTextColor() {
            return (QColor) interceptor.Invoke("defaultTextColor", "defaultTextColor() const", typeof(QColor));
        }
        // [SmokeMethod("boundingRect() const")]
        // public override QRectF BoundingRect() {
        //    return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
        // }
        [SmokeMethod("shape() const")]
        public override QPainterPath Shape() {
            return (QPainterPath) interceptor.Invoke("shape", "shape() const", typeof(QPainterPath));
        }
        [SmokeMethod("contains(const QPointF&) const")]
        public override bool Contains(QPointF point) {
            return (bool) interceptor.Invoke("contains#", "contains(const QPointF&) const", typeof(bool), typeof(QPointF), point);
        }
        // [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        // public override void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
        //    interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        // }
        [SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
        public override bool IsObscuredBy(IQGraphicsItem item) {
            return (bool) interceptor.Invoke("isObscuredBy#", "isObscuredBy(const QGraphicsItem*) const", typeof(bool), typeof(IQGraphicsItem), item);
        }
        [SmokeMethod("opaqueArea() const")]
        public override QPainterPath OpaqueArea() {
            return (QPainterPath) interceptor.Invoke("opaqueArea", "opaqueArea() const", typeof(QPainterPath));
        }
        [SmokeMethod("type() const")]
        public override int type() {
            return (int) interceptor.Invoke("type", "type() const", typeof(int));
        }
        public void SetTextWidth(double width) {
            interceptor.Invoke("setTextWidth$", "setTextWidth(qreal)", typeof(void), typeof(double), width);
        }
        public double TextWidth() {
            return (double) interceptor.Invoke("textWidth", "textWidth() const", typeof(double));
        }
        public void AdjustSize() {
            interceptor.Invoke("adjustSize", "adjustSize()", typeof(void));
        }
        public void SetDocument(QTextDocument document) {
            interceptor.Invoke("setDocument#", "setDocument(QTextDocument*)", typeof(void), typeof(QTextDocument), document);
        }
        public QTextDocument Document() {
            return (QTextDocument) interceptor.Invoke("document", "document() const", typeof(QTextDocument));
        }
        public void SetTextInteractionFlags(uint flags) {
            interceptor.Invoke("setTextInteractionFlags$", "setTextInteractionFlags(Qt::TextInteractionFlags)", typeof(void), typeof(uint), flags);
        }
        public uint TextInteractionFlags() {
            return (uint) interceptor.Invoke("textInteractionFlags", "textInteractionFlags() const", typeof(uint));
        }
        public void SetTabChangesFocus(bool b) {
            interceptor.Invoke("setTabChangesFocus$", "setTabChangesFocus(bool)", typeof(void), typeof(bool), b);
        }
        public bool TabChangesFocus() {
            return (bool) interceptor.Invoke("tabChangesFocus", "tabChangesFocus() const", typeof(bool));
        }
        [SmokeMethod("sceneEvent(QEvent*)")]
        protected override bool SceneEvent(QEvent arg1) {
            return (bool) interceptor.Invoke("sceneEvent#", "sceneEvent(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        [SmokeMethod("mousePressEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseMoveEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseReleaseEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseDoubleClickEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("contextMenuEvent(QGraphicsSceneContextMenuEvent*)")]
        protected override void ContextMenuEvent(QGraphicsSceneContextMenuEvent arg1) {
            interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QGraphicsSceneContextMenuEvent*)", typeof(void), typeof(QGraphicsSceneContextMenuEvent), arg1);
        }
        [SmokeMethod("keyPressEvent(QKeyEvent*)")]
        protected override void KeyPressEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        [SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
        protected override void KeyReleaseEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyReleaseEvent#", "keyReleaseEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        [SmokeMethod("focusInEvent(QFocusEvent*)")]
        protected override void FocusInEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        [SmokeMethod("focusOutEvent(QFocusEvent*)")]
        protected override void FocusOutEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        [SmokeMethod("dragEnterEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DragEnterEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        [SmokeMethod("dragLeaveEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DragLeaveEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        [SmokeMethod("dragMoveEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DragMoveEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        [SmokeMethod("dropEvent(QGraphicsSceneDragDropEvent*)")]
        protected override void DropEvent(QGraphicsSceneDragDropEvent arg1) {
            interceptor.Invoke("dropEvent#", "dropEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
        }
        [SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
        protected override void InputMethodEvent(QInputMethodEvent arg1) {
            interceptor.Invoke("inputMethodEvent#", "inputMethodEvent(QInputMethodEvent*)", typeof(void), typeof(QInputMethodEvent), arg1);
        }
        [SmokeMethod("hoverEnterEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverEnterEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverEnterEvent#", "hoverEnterEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("hoverMoveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverMoveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverMoveEvent#", "hoverMoveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("hoverLeaveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverLeaveEvent#", "hoverLeaveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
        protected new QVariant InputMethodQuery(Qt.InputMethodQuery query) {
            return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), query);
        }
        [SmokeMethod("supportsExtension(QGraphicsItem::Extension) const")]
        protected override bool SupportsExtension(QGraphicsItem.Extension extension) {
            return (bool) interceptor.Invoke("supportsExtension$", "supportsExtension(QGraphicsItem::Extension) const", typeof(bool), typeof(QGraphicsItem.Extension), extension);
        }
        [SmokeMethod("setExtension(QGraphicsItem::Extension, const QVariant&)")]
        protected override void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
            interceptor.Invoke("setExtension$#", "setExtension(QGraphicsItem::Extension, const QVariant&)", typeof(void), typeof(QGraphicsItem.Extension), extension, typeof(QVariant), variant);
        }
        [SmokeMethod("extension(const QVariant&) const")]
        protected override QVariant extension(QVariant variant) {
            return (QVariant) interceptor.Invoke("extension#", "extension(const QVariant&) const", typeof(QVariant), typeof(QVariant), variant);
        }
        ~QGraphicsTextItem() {
            interceptor.Invoke("~QGraphicsTextItem", "~QGraphicsTextItem()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QGraphicsTextItem", "~QGraphicsTextItem()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQGraphicsTextItemSignals Emit {
            get { return (IQGraphicsTextItemSignals) Q_EMIT; }
        }
    }

    public interface IQGraphicsTextItemSignals : IQGraphicsObjectSignals {
        [Q_SIGNAL("void linkActivated(QString)")]
        void LinkActivated(string arg1);
        [Q_SIGNAL("void linkHovered(QString)")]
        void LinkHovered(string arg1);
    }
}
