//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QStyleOptionViewItem")]
    public class QStyleOptionViewItem : QStyleOption, IDisposable {
        protected QStyleOptionViewItem(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QStyleOptionViewItem), this);
        }
        public enum StyleOptionType {
            Type = QStyleOption.OptionType.SO_ViewItem,
        }
        public enum StyleOptionVersion {
            Version = 1,
        }
        public enum Position {
            Left = 0,
            Right = 1,
            Top = 2,
            Bottom = 3,
        }
        public uint DisplayAlignment {
            get { return (uint) interceptor.Invoke("displayAlignment", "displayAlignment()", typeof(uint)); }
            set { interceptor.Invoke("setDisplayAlignment$", "setDisplayAlignment(Qt::Alignment)", typeof(void), typeof(uint), value); }
        }
        public uint DecorationAlignment {
            get { return (uint) interceptor.Invoke("decorationAlignment", "decorationAlignment()", typeof(uint)); }
            set { interceptor.Invoke("setDecorationAlignment$", "setDecorationAlignment(Qt::Alignment)", typeof(void), typeof(uint), value); }
        }
        public Qt.TextElideMode TextElideMode {
            get { return (Qt.TextElideMode) interceptor.Invoke("textElideMode", "textElideMode()", typeof(Qt.TextElideMode)); }
            set { interceptor.Invoke("setTextElideMode$", "setTextElideMode(Qt::TextElideMode)", typeof(void), typeof(Qt.TextElideMode), value); }
        }
        public QStyleOptionViewItem.Position DecorationPosition {
            get { return (QStyleOptionViewItem.Position) interceptor.Invoke("decorationPosition", "decorationPosition()", typeof(QStyleOptionViewItem.Position)); }
            set { interceptor.Invoke("setDecorationPosition$", "setDecorationPosition(QStyleOptionViewItem::Position)", typeof(void), typeof(QStyleOptionViewItem.Position), value); }
        }
        public QSize DecorationSize {
            get { return (QSize) interceptor.Invoke("decorationSize", "decorationSize()", typeof(QSize)); }
            set { interceptor.Invoke("setDecorationSize#", "setDecorationSize(QSize)", typeof(void), typeof(QSize), value); }
        }
        public QFont Font {
            get { return (QFont) interceptor.Invoke("font", "font()", typeof(QFont)); }
            set { interceptor.Invoke("setFont#", "setFont(QFont)", typeof(void), typeof(QFont), value); }
        }
        public bool ShowDecorationSelected {
            get { return (bool) interceptor.Invoke("showDecorationSelected", "showDecorationSelected()", typeof(bool)); }
            set { interceptor.Invoke("setShowDecorationSelected$", "setShowDecorationSelected(bool)", typeof(void), typeof(bool), value); }
        }
        public QStyleOptionViewItem() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionViewItem", "QStyleOptionViewItem()", typeof(void));
        }
        public QStyleOptionViewItem(QStyleOptionViewItem other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionViewItem#", "QStyleOptionViewItem(const QStyleOptionViewItem&)", typeof(void), typeof(QStyleOptionViewItem), other);
        }
        public QStyleOptionViewItem(int version) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionViewItem$", "QStyleOptionViewItem(int)", typeof(void), typeof(int), version);
        }
        ~QStyleOptionViewItem() {
            interceptor.Invoke("~QStyleOptionViewItem", "~QStyleOptionViewItem()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QStyleOptionViewItem", "~QStyleOptionViewItem()", typeof(void));
        }
    }
}
