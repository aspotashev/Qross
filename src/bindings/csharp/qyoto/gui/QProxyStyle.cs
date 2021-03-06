//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QProxyStyle")]
    public class QProxyStyle : QCommonStyle, IDisposable {
        protected QProxyStyle(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QProxyStyle), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QProxyStyle() {
            staticInterceptor = new SmokeInvocation(typeof(QProxyStyle), null);
        }
        public QProxyStyle(QStyle baseStyle) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QProxyStyle#", "QProxyStyle(QStyle*)", typeof(void), typeof(QStyle), baseStyle);
        }
        public QProxyStyle() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QProxyStyle", "QProxyStyle()", typeof(void));
        }
        public QStyle BaseStyle() {
            return (QStyle) interceptor.Invoke("baseStyle", "baseStyle() const", typeof(QStyle));
        }
        public void SetBaseStyle(QStyle style) {
            interceptor.Invoke("setBaseStyle#", "setBaseStyle(QStyle*)", typeof(void), typeof(QStyle), style);
        }
        [SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const")]
        public override void DrawPrimitive(QStyle.PrimitiveElement element, QStyleOption option, QPainter painter, QWidget widget) {
            interceptor.Invoke("drawPrimitive$###", "drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const", typeof(void), typeof(QStyle.PrimitiveElement), element, typeof(QStyleOption), option, typeof(QPainter), painter, typeof(QWidget), widget);
        }
        [SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const")]
        public override void DrawPrimitive(QStyle.PrimitiveElement element, QStyleOption option, QPainter painter) {
            interceptor.Invoke("drawPrimitive$##", "drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const", typeof(void), typeof(QStyle.PrimitiveElement), element, typeof(QStyleOption), option, typeof(QPainter), painter);
        }
        [SmokeMethod("drawControl(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const")]
        public override void DrawControl(QStyle.ControlElement element, QStyleOption option, QPainter painter, QWidget widget) {
            interceptor.Invoke("drawControl$###", "drawControl(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const", typeof(void), typeof(QStyle.ControlElement), element, typeof(QStyleOption), option, typeof(QPainter), painter, typeof(QWidget), widget);
        }
        [SmokeMethod("drawControl(QStyle::ControlElement, const QStyleOption*, QPainter*) const")]
        public override void DrawControl(QStyle.ControlElement element, QStyleOption option, QPainter painter) {
            interceptor.Invoke("drawControl$##", "drawControl(QStyle::ControlElement, const QStyleOption*, QPainter*) const", typeof(void), typeof(QStyle.ControlElement), element, typeof(QStyleOption), option, typeof(QPainter), painter);
        }
        [SmokeMethod("drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const")]
        public override void DrawComplexControl(QStyle.ComplexControl control, QStyleOptionComplex option, QPainter painter, QWidget widget) {
            interceptor.Invoke("drawComplexControl$###", "drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const", typeof(void), typeof(QStyle.ComplexControl), control, typeof(QStyleOptionComplex), option, typeof(QPainter), painter, typeof(QWidget), widget);
        }
        [SmokeMethod("drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*) const")]
        public override void DrawComplexControl(QStyle.ComplexControl control, QStyleOptionComplex option, QPainter painter) {
            interceptor.Invoke("drawComplexControl$##", "drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*) const", typeof(void), typeof(QStyle.ComplexControl), control, typeof(QStyleOptionComplex), option, typeof(QPainter), painter);
        }
        [SmokeMethod("drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole) const")]
        public override void DrawItemText(QPainter painter, QRect rect, int flags, QPalette pal, bool enabled, string text, QPalette.ColorRole textRole) {
            interceptor.Invoke("drawItemText##$#$$$", "drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole) const", typeof(void), typeof(QPainter), painter, typeof(QRect), rect, typeof(int), flags, typeof(QPalette), pal, typeof(bool), enabled, typeof(string), text, typeof(QPalette.ColorRole), textRole);
        }
        [SmokeMethod("drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&) const")]
        public override void DrawItemText(QPainter painter, QRect rect, int flags, QPalette pal, bool enabled, string text) {
            interceptor.Invoke("drawItemText##$#$$", "drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&) const", typeof(void), typeof(QPainter), painter, typeof(QRect), rect, typeof(int), flags, typeof(QPalette), pal, typeof(bool), enabled, typeof(string), text);
        }
        [SmokeMethod("drawItemPixmap(QPainter*, const QRect&, int, const QPixmap&) const")]
        public override void DrawItemPixmap(QPainter painter, QRect rect, int alignment, QPixmap pixmap) {
            interceptor.Invoke("drawItemPixmap##$#", "drawItemPixmap(QPainter*, const QRect&, int, const QPixmap&) const", typeof(void), typeof(QPainter), painter, typeof(QRect), rect, typeof(int), alignment, typeof(QPixmap), pixmap);
        }
        [SmokeMethod("sizeFromContents(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const")]
        public override QSize SizeFromContents(QStyle.ContentsType type, QStyleOption option, QSize size, QWidget widget) {
            return (QSize) interceptor.Invoke("sizeFromContents$###", "sizeFromContents(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const", typeof(QSize), typeof(QStyle.ContentsType), type, typeof(QStyleOption), option, typeof(QSize), size, typeof(QWidget), widget);
        }
        [SmokeMethod("subElementRect(QStyle::SubElement, const QStyleOption*, const QWidget*) const")]
        public override QRect SubElementRect(QStyle.SubElement element, QStyleOption option, QWidget widget) {
            return (QRect) interceptor.Invoke("subElementRect$##", "subElementRect(QStyle::SubElement, const QStyleOption*, const QWidget*) const", typeof(QRect), typeof(QStyle.SubElement), element, typeof(QStyleOption), option, typeof(QWidget), widget);
        }
        [SmokeMethod("subControlRect(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl, const QWidget*) const")]
        public override QRect SubControlRect(QStyle.ComplexControl cc, QStyleOptionComplex opt, QStyle.SubControl sc, QWidget widget) {
            return (QRect) interceptor.Invoke("subControlRect$#$#", "subControlRect(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl, const QWidget*) const", typeof(QRect), typeof(QStyle.ComplexControl), cc, typeof(QStyleOptionComplex), opt, typeof(QStyle.SubControl), sc, typeof(QWidget), widget);
        }
        [SmokeMethod("itemTextRect(const QFontMetrics&, const QRect&, int, bool, const QString&) const")]
        public override QRect ItemTextRect(QFontMetrics fm, QRect r, int flags, bool enabled, string text) {
            return (QRect) interceptor.Invoke("itemTextRect##$$$", "itemTextRect(const QFontMetrics&, const QRect&, int, bool, const QString&) const", typeof(QRect), typeof(QFontMetrics), fm, typeof(QRect), r, typeof(int), flags, typeof(bool), enabled, typeof(string), text);
        }
        [SmokeMethod("itemPixmapRect(const QRect&, int, const QPixmap&) const")]
        public override QRect ItemPixmapRect(QRect r, int flags, QPixmap pixmap) {
            return (QRect) interceptor.Invoke("itemPixmapRect#$#", "itemPixmapRect(const QRect&, int, const QPixmap&) const", typeof(QRect), typeof(QRect), r, typeof(int), flags, typeof(QPixmap), pixmap);
        }
        [SmokeMethod("hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&, const QWidget*) const")]
        public override QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl control, QStyleOptionComplex option, QPoint pos, QWidget widget) {
            return (QStyle.SubControl) interceptor.Invoke("hitTestComplexControl$###", "hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&, const QWidget*) const", typeof(QStyle.SubControl), typeof(QStyle.ComplexControl), control, typeof(QStyleOptionComplex), option, typeof(QPoint), pos, typeof(QWidget), widget);
        }
        [SmokeMethod("hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&) const")]
        public override QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl control, QStyleOptionComplex option, QPoint pos) {
            return (QStyle.SubControl) interceptor.Invoke("hitTestComplexControl$##", "hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&) const", typeof(QStyle.SubControl), typeof(QStyle.ComplexControl), control, typeof(QStyleOptionComplex), option, typeof(QPoint), pos);
        }
        [SmokeMethod("styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const")]
        public override int styleHint(QStyle.StyleHint hint, QStyleOption option, QWidget widget, QStyleHintReturn returnData) {
            return (int) interceptor.Invoke("styleHint$###", "styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const", typeof(int), typeof(QStyle.StyleHint), hint, typeof(QStyleOption), option, typeof(QWidget), widget, typeof(QStyleHintReturn), returnData);
        }
        [SmokeMethod("styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*) const")]
        public override int styleHint(QStyle.StyleHint hint, QStyleOption option, QWidget widget) {
            return (int) interceptor.Invoke("styleHint$##", "styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*) const", typeof(int), typeof(QStyle.StyleHint), hint, typeof(QStyleOption), option, typeof(QWidget), widget);
        }
        [SmokeMethod("styleHint(QStyle::StyleHint, const QStyleOption*) const")]
        public override int styleHint(QStyle.StyleHint hint, QStyleOption option) {
            return (int) interceptor.Invoke("styleHint$#", "styleHint(QStyle::StyleHint, const QStyleOption*) const", typeof(int), typeof(QStyle.StyleHint), hint, typeof(QStyleOption), option);
        }
        [SmokeMethod("styleHint(QStyle::StyleHint) const")]
        public override int styleHint(QStyle.StyleHint hint) {
            return (int) interceptor.Invoke("styleHint$", "styleHint(QStyle::StyleHint) const", typeof(int), typeof(QStyle.StyleHint), hint);
        }
        [SmokeMethod("pixelMetric(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const")]
        public override int pixelMetric(QStyle.PixelMetric metric, QStyleOption option, QWidget widget) {
            return (int) interceptor.Invoke("pixelMetric$##", "pixelMetric(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const", typeof(int), typeof(QStyle.PixelMetric), metric, typeof(QStyleOption), option, typeof(QWidget), widget);
        }
        [SmokeMethod("pixelMetric(QStyle::PixelMetric, const QStyleOption*) const")]
        public override int pixelMetric(QStyle.PixelMetric metric, QStyleOption option) {
            return (int) interceptor.Invoke("pixelMetric$#", "pixelMetric(QStyle::PixelMetric, const QStyleOption*) const", typeof(int), typeof(QStyle.PixelMetric), metric, typeof(QStyleOption), option);
        }
        [SmokeMethod("pixelMetric(QStyle::PixelMetric) const")]
        public override int pixelMetric(QStyle.PixelMetric metric) {
            return (int) interceptor.Invoke("pixelMetric$", "pixelMetric(QStyle::PixelMetric) const", typeof(int), typeof(QStyle.PixelMetric), metric);
        }
        [SmokeMethod("standardPixmap(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const")]
        public override QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap, QStyleOption opt, QWidget widget) {
            return (QPixmap) interceptor.Invoke("standardPixmap$##", "standardPixmap(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", typeof(QPixmap), typeof(QStyle.StandardPixmap), standardPixmap, typeof(QStyleOption), opt, typeof(QWidget), widget);
        }
        [SmokeMethod("standardPixmap(QStyle::StandardPixmap, const QStyleOption*) const")]
        public override QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap, QStyleOption opt) {
            return (QPixmap) interceptor.Invoke("standardPixmap$#", "standardPixmap(QStyle::StandardPixmap, const QStyleOption*) const", typeof(QPixmap), typeof(QStyle.StandardPixmap), standardPixmap, typeof(QStyleOption), opt);
        }
        [SmokeMethod("generatedIconPixmap(QIcon::Mode, const QPixmap&, const QStyleOption*) const")]
        public override QPixmap GeneratedIconPixmap(QIcon.Mode iconMode, QPixmap pixmap, QStyleOption opt) {
            return (QPixmap) interceptor.Invoke("generatedIconPixmap$##", "generatedIconPixmap(QIcon::Mode, const QPixmap&, const QStyleOption*) const", typeof(QPixmap), typeof(QIcon.Mode), iconMode, typeof(QPixmap), pixmap, typeof(QStyleOption), opt);
        }
        [SmokeMethod("standardPalette() const")]
        public override QPalette StandardPalette() {
            return (QPalette) interceptor.Invoke("standardPalette", "standardPalette() const", typeof(QPalette));
        }
        [SmokeMethod("polish(QWidget*)")]
        public override void Polish(QWidget widget) {
            interceptor.Invoke("polish#", "polish(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        [SmokeMethod("polish(QPalette&)")]
        public override void Polish(QPalette pal) {
            interceptor.Invoke("polish#", "polish(QPalette&)", typeof(void), typeof(QPalette), pal);
        }
        [SmokeMethod("polish(QApplication*)")]
        public override void Polish(QApplication app) {
            interceptor.Invoke("polish#", "polish(QApplication*)", typeof(void), typeof(QApplication), app);
        }
        [SmokeMethod("unpolish(QWidget*)")]
        public override void Unpolish(QWidget widget) {
            interceptor.Invoke("unpolish#", "unpolish(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        [SmokeMethod("unpolish(QApplication*)")]
        public override void Unpolish(QApplication app) {
            interceptor.Invoke("unpolish#", "unpolish(QApplication*)", typeof(void), typeof(QApplication), app);
        }
        [SmokeMethod("event(QEvent*)")]
        protected new virtual bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [Q_SLOT("QIcon standardIconImplementation(StandardPixmap, QStyleOption*, QWidget*)")]
        protected new QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, QStyleOption option, QWidget widget) {
            return (QIcon) interceptor.Invoke("standardIconImplementation$##", "standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", typeof(QIcon), typeof(QStyle.StandardPixmap), standardIcon, typeof(QStyleOption), option, typeof(QWidget), widget);
        }
        [Q_SLOT("int layoutSpacingImplementation(QSizePolicy::ControlType, QSizePolicy::ControlType, Qt::Orientation, QStyleOption*, QWidget*)")]
        protected new int LayoutSpacingImplementation(QSizePolicy.ControlType control1, QSizePolicy.ControlType control2, Qt.Orientation orientation, QStyleOption option, QWidget widget) {
            return (int) interceptor.Invoke("layoutSpacingImplementation$$$##", "layoutSpacingImplementation(QSizePolicy::ControlType, QSizePolicy::ControlType, Qt::Orientation, const QStyleOption*, const QWidget*) const", typeof(int), typeof(QSizePolicy.ControlType), control1, typeof(QSizePolicy.ControlType), control2, typeof(Qt.Orientation), orientation, typeof(QStyleOption), option, typeof(QWidget), widget);
        }
        [Q_SLOT("int layoutSpacingImplementation(QSizePolicy::ControlType, QSizePolicy::ControlType, Qt::Orientation, QStyleOption*)")]
        protected new int LayoutSpacingImplementation(QSizePolicy.ControlType control1, QSizePolicy.ControlType control2, Qt.Orientation orientation, QStyleOption option) {
            return (int) interceptor.Invoke("layoutSpacingImplementation$$$#", "layoutSpacingImplementation(QSizePolicy::ControlType, QSizePolicy::ControlType, Qt::Orientation, const QStyleOption*) const", typeof(int), typeof(QSizePolicy.ControlType), control1, typeof(QSizePolicy.ControlType), control2, typeof(Qt.Orientation), orientation, typeof(QStyleOption), option);
        }
        [Q_SLOT("int layoutSpacingImplementation(QSizePolicy::ControlType, QSizePolicy::ControlType, Qt::Orientation)")]
        protected new int LayoutSpacingImplementation(QSizePolicy.ControlType control1, QSizePolicy.ControlType control2, Qt.Orientation orientation) {
            return (int) interceptor.Invoke("layoutSpacingImplementation$$$", "layoutSpacingImplementation(QSizePolicy::ControlType, QSizePolicy::ControlType, Qt::Orientation) const", typeof(int), typeof(QSizePolicy.ControlType), control1, typeof(QSizePolicy.ControlType), control2, typeof(Qt.Orientation), orientation);
        }
        ~QProxyStyle() {
            interceptor.Invoke("~QProxyStyle", "~QProxyStyle()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QProxyStyle", "~QProxyStyle()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQProxyStyleSignals Emit {
            get { return (IQProxyStyleSignals) Q_EMIT; }
        }
    }

    public interface IQProxyStyleSignals : IQCommonStyleSignals {
    }
}
