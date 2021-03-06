//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QColor")]
    public partial class QColor : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QColor(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QColor), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QColor() {
            staticInterceptor = new SmokeInvocation(typeof(QColor), null);
        }
        public enum Spec {
            Invalid = 0,
            Rgb = 1,
            Hsv = 2,
            Cmyk = 3,
            Hsl = 4,
        }
        public QColor() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor", "QColor()", typeof(void));
        }
        public QColor(Qt.GlobalColor color) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor$", "QColor(Qt::GlobalColor)", typeof(void), typeof(Qt.GlobalColor), color);
        }
        public QColor(int r, int g, int b, int a) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor$$$$", "QColor(int, int, int, int)", typeof(void), typeof(int), r, typeof(int), g, typeof(int), b, typeof(int), a);
        }
        public QColor(int r, int g, int b) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor$$$", "QColor(int, int, int)", typeof(void), typeof(int), r, typeof(int), g, typeof(int), b);
        }
        public QColor(uint rgb) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor$", "QColor(unsigned int)", typeof(void), typeof(uint), rgb);
        }
        public QColor(string name) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor$", "QColor(const QString&)", typeof(void), typeof(string), name);
        }
        public QColor(QColor color) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor#", "QColor(const QColor&)", typeof(void), typeof(QColor), color);
        }
        public QColor(QColor.Spec spec) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QColor$", "QColor(QColor::Spec)", typeof(void), typeof(QColor.Spec), spec);
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public string Name() {
            return (string) interceptor.Invoke("name", "name() const", typeof(string));
        }
        public void SetNamedColor(string name) {
            interceptor.Invoke("setNamedColor$", "setNamedColor(const QString&)", typeof(void), typeof(string), name);
        }
        public QColor.Spec spec() {
            return (QColor.Spec) interceptor.Invoke("spec", "spec() const", typeof(QColor.Spec));
        }
        public int Alpha() {
            return (int) interceptor.Invoke("alpha", "alpha() const", typeof(int));
        }
        public void SetAlpha(int alpha) {
            interceptor.Invoke("setAlpha$", "setAlpha(int)", typeof(void), typeof(int), alpha);
        }
        public double AlphaF() {
            return (double) interceptor.Invoke("alphaF", "alphaF() const", typeof(double));
        }
        public void SetAlphaF(double alpha) {
            interceptor.Invoke("setAlphaF$", "setAlphaF(qreal)", typeof(void), typeof(double), alpha);
        }
        public int Red() {
            return (int) interceptor.Invoke("red", "red() const", typeof(int));
        }
        public int Green() {
            return (int) interceptor.Invoke("green", "green() const", typeof(int));
        }
        public int Blue() {
            return (int) interceptor.Invoke("blue", "blue() const", typeof(int));
        }
        public void SetRed(int red) {
            interceptor.Invoke("setRed$", "setRed(int)", typeof(void), typeof(int), red);
        }
        public void SetGreen(int green) {
            interceptor.Invoke("setGreen$", "setGreen(int)", typeof(void), typeof(int), green);
        }
        public void SetBlue(int blue) {
            interceptor.Invoke("setBlue$", "setBlue(int)", typeof(void), typeof(int), blue);
        }
        public double RedF() {
            return (double) interceptor.Invoke("redF", "redF() const", typeof(double));
        }
        public double GreenF() {
            return (double) interceptor.Invoke("greenF", "greenF() const", typeof(double));
        }
        public double BlueF() {
            return (double) interceptor.Invoke("blueF", "blueF() const", typeof(double));
        }
        public void SetRedF(double red) {
            interceptor.Invoke("setRedF$", "setRedF(qreal)", typeof(void), typeof(double), red);
        }
        public void SetGreenF(double green) {
            interceptor.Invoke("setGreenF$", "setGreenF(qreal)", typeof(void), typeof(double), green);
        }
        public void SetBlueF(double blue) {
            interceptor.Invoke("setBlueF$", "setBlueF(qreal)", typeof(void), typeof(double), blue);
        }
        public void GetRgb(ref int r, ref int g, ref int b, ref int a) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = r;
            stack[2].s_int = g;
            stack[3].s_int = b;
            stack[4].s_int = a;
            interceptor.Invoke("getRgb$$$$", "getRgb(int*, int*, int*, int*) const", stack);
            r = stack[1].s_int;
            g = stack[2].s_int;
            b = stack[3].s_int;
            a = stack[4].s_int;
            return;
        }
        public void GetRgb(ref int r, ref int g, ref int b) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_int = r;
            stack[2].s_int = g;
            stack[3].s_int = b;
            interceptor.Invoke("getRgb$$$", "getRgb(int*, int*, int*) const", stack);
            r = stack[1].s_int;
            g = stack[2].s_int;
            b = stack[3].s_int;
            return;
        }
        public void SetRgb(int r, int g, int b, int a) {
            interceptor.Invoke("setRgb$$$$", "setRgb(int, int, int, int)", typeof(void), typeof(int), r, typeof(int), g, typeof(int), b, typeof(int), a);
        }
        public void SetRgb(int r, int g, int b) {
            interceptor.Invoke("setRgb$$$", "setRgb(int, int, int)", typeof(void), typeof(int), r, typeof(int), g, typeof(int), b);
        }
        public void GetRgbF(ref double r, ref double g, ref double b, ref double a) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_double = r;
            stack[2].s_double = g;
            stack[3].s_double = b;
            stack[4].s_double = a;
            interceptor.Invoke("getRgbF$$$$", "getRgbF(qreal*, qreal*, qreal*, qreal*) const", stack);
            r = stack[1].s_double;
            g = stack[2].s_double;
            b = stack[3].s_double;
            a = stack[4].s_double;
            return;
        }
        public void GetRgbF(ref double r, ref double g, ref double b) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_double = r;
            stack[2].s_double = g;
            stack[3].s_double = b;
            interceptor.Invoke("getRgbF$$$", "getRgbF(qreal*, qreal*, qreal*) const", stack);
            r = stack[1].s_double;
            g = stack[2].s_double;
            b = stack[3].s_double;
            return;
        }
        public void SetRgbF(double r, double g, double b, double a) {
            interceptor.Invoke("setRgbF$$$$", "setRgbF(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), r, typeof(double), g, typeof(double), b, typeof(double), a);
        }
        public void SetRgbF(double r, double g, double b) {
            interceptor.Invoke("setRgbF$$$", "setRgbF(qreal, qreal, qreal)", typeof(void), typeof(double), r, typeof(double), g, typeof(double), b);
        }
        public uint Rgba() {
            return (uint) interceptor.Invoke("rgba", "rgba() const", typeof(uint));
        }
        public void SetRgba(uint rgba) {
            interceptor.Invoke("setRgba$", "setRgba(unsigned int)", typeof(void), typeof(uint), rgba);
        }
        public uint Rgb() {
            return (uint) interceptor.Invoke("rgb", "rgb() const", typeof(uint));
        }
        public void SetRgb(uint rgb) {
            interceptor.Invoke("setRgb$", "setRgb(unsigned int)", typeof(void), typeof(uint), rgb);
        }
        public int Hue() {
            return (int) interceptor.Invoke("hue", "hue() const", typeof(int));
        }
        public int Saturation() {
            return (int) interceptor.Invoke("saturation", "saturation() const", typeof(int));
        }
        public int HsvHue() {
            return (int) interceptor.Invoke("hsvHue", "hsvHue() const", typeof(int));
        }
        public int HsvSaturation() {
            return (int) interceptor.Invoke("hsvSaturation", "hsvSaturation() const", typeof(int));
        }
        public int Value() {
            return (int) interceptor.Invoke("value", "value() const", typeof(int));
        }
        public double HueF() {
            return (double) interceptor.Invoke("hueF", "hueF() const", typeof(double));
        }
        public double SaturationF() {
            return (double) interceptor.Invoke("saturationF", "saturationF() const", typeof(double));
        }
        public double HsvHueF() {
            return (double) interceptor.Invoke("hsvHueF", "hsvHueF() const", typeof(double));
        }
        public double HsvSaturationF() {
            return (double) interceptor.Invoke("hsvSaturationF", "hsvSaturationF() const", typeof(double));
        }
        public double ValueF() {
            return (double) interceptor.Invoke("valueF", "valueF() const", typeof(double));
        }
        public void GetHsv(ref int h, ref int s, ref int v, ref int a) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = h;
            stack[2].s_int = s;
            stack[3].s_int = v;
            stack[4].s_int = a;
            interceptor.Invoke("getHsv$$$$", "getHsv(int*, int*, int*, int*) const", stack);
            h = stack[1].s_int;
            s = stack[2].s_int;
            v = stack[3].s_int;
            a = stack[4].s_int;
            return;
        }
        public void GetHsv(ref int h, ref int s, ref int v) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_int = h;
            stack[2].s_int = s;
            stack[3].s_int = v;
            interceptor.Invoke("getHsv$$$", "getHsv(int*, int*, int*) const", stack);
            h = stack[1].s_int;
            s = stack[2].s_int;
            v = stack[3].s_int;
            return;
        }
        public void SetHsv(int h, int s, int v, int a) {
            interceptor.Invoke("setHsv$$$$", "setHsv(int, int, int, int)", typeof(void), typeof(int), h, typeof(int), s, typeof(int), v, typeof(int), a);
        }
        public void SetHsv(int h, int s, int v) {
            interceptor.Invoke("setHsv$$$", "setHsv(int, int, int)", typeof(void), typeof(int), h, typeof(int), s, typeof(int), v);
        }
        public void GetHsvF(ref double h, ref double s, ref double v, ref double a) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_double = h;
            stack[2].s_double = s;
            stack[3].s_double = v;
            stack[4].s_double = a;
            interceptor.Invoke("getHsvF$$$$", "getHsvF(qreal*, qreal*, qreal*, qreal*) const", stack);
            h = stack[1].s_double;
            s = stack[2].s_double;
            v = stack[3].s_double;
            a = stack[4].s_double;
            return;
        }
        public void GetHsvF(ref double h, ref double s, ref double v) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_double = h;
            stack[2].s_double = s;
            stack[3].s_double = v;
            interceptor.Invoke("getHsvF$$$", "getHsvF(qreal*, qreal*, qreal*) const", stack);
            h = stack[1].s_double;
            s = stack[2].s_double;
            v = stack[3].s_double;
            return;
        }
        public void SetHsvF(double h, double s, double v, double a) {
            interceptor.Invoke("setHsvF$$$$", "setHsvF(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), h, typeof(double), s, typeof(double), v, typeof(double), a);
        }
        public void SetHsvF(double h, double s, double v) {
            interceptor.Invoke("setHsvF$$$", "setHsvF(qreal, qreal, qreal)", typeof(void), typeof(double), h, typeof(double), s, typeof(double), v);
        }
        public int Cyan() {
            return (int) interceptor.Invoke("cyan", "cyan() const", typeof(int));
        }
        public int Magenta() {
            return (int) interceptor.Invoke("magenta", "magenta() const", typeof(int));
        }
        public int Yellow() {
            return (int) interceptor.Invoke("yellow", "yellow() const", typeof(int));
        }
        public int Black() {
            return (int) interceptor.Invoke("black", "black() const", typeof(int));
        }
        public double CyanF() {
            return (double) interceptor.Invoke("cyanF", "cyanF() const", typeof(double));
        }
        public double MagentaF() {
            return (double) interceptor.Invoke("magentaF", "magentaF() const", typeof(double));
        }
        public double YellowF() {
            return (double) interceptor.Invoke("yellowF", "yellowF() const", typeof(double));
        }
        public double BlackF() {
            return (double) interceptor.Invoke("blackF", "blackF() const", typeof(double));
        }
        public void GetCmyk(ref int c, ref int m, ref int y, ref int k, ref int a) {
            StackItem[] stack = new StackItem[6];
            stack[1].s_int = c;
            stack[2].s_int = m;
            stack[3].s_int = y;
            stack[4].s_int = k;
            stack[5].s_int = a;
            interceptor.Invoke("getCmyk$$$$$", "getCmyk(int*, int*, int*, int*, int*)", stack);
            c = stack[1].s_int;
            m = stack[2].s_int;
            y = stack[3].s_int;
            k = stack[4].s_int;
            a = stack[5].s_int;
            return;
        }
        public void GetCmyk(ref int c, ref int m, ref int y, ref int k) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = c;
            stack[2].s_int = m;
            stack[3].s_int = y;
            stack[4].s_int = k;
            interceptor.Invoke("getCmyk$$$$", "getCmyk(int*, int*, int*, int*)", stack);
            c = stack[1].s_int;
            m = stack[2].s_int;
            y = stack[3].s_int;
            k = stack[4].s_int;
            return;
        }
        public void SetCmyk(int c, int m, int y, int k, int a) {
            interceptor.Invoke("setCmyk$$$$$", "setCmyk(int, int, int, int, int)", typeof(void), typeof(int), c, typeof(int), m, typeof(int), y, typeof(int), k, typeof(int), a);
        }
        public void SetCmyk(int c, int m, int y, int k) {
            interceptor.Invoke("setCmyk$$$$", "setCmyk(int, int, int, int)", typeof(void), typeof(int), c, typeof(int), m, typeof(int), y, typeof(int), k);
        }
        public void GetCmykF(ref double c, ref double m, ref double y, ref double k, ref double a) {
            StackItem[] stack = new StackItem[6];
            stack[1].s_double = c;
            stack[2].s_double = m;
            stack[3].s_double = y;
            stack[4].s_double = k;
            stack[5].s_double = a;
            interceptor.Invoke("getCmykF$$$$$", "getCmykF(qreal*, qreal*, qreal*, qreal*, qreal*)", stack);
            c = stack[1].s_double;
            m = stack[2].s_double;
            y = stack[3].s_double;
            k = stack[4].s_double;
            a = stack[5].s_double;
            return;
        }
        public void GetCmykF(ref double c, ref double m, ref double y, ref double k) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_double = c;
            stack[2].s_double = m;
            stack[3].s_double = y;
            stack[4].s_double = k;
            interceptor.Invoke("getCmykF$$$$", "getCmykF(qreal*, qreal*, qreal*, qreal*)", stack);
            c = stack[1].s_double;
            m = stack[2].s_double;
            y = stack[3].s_double;
            k = stack[4].s_double;
            return;
        }
        public void SetCmykF(double c, double m, double y, double k, double a) {
            interceptor.Invoke("setCmykF$$$$$", "setCmykF(qreal, qreal, qreal, qreal, qreal)", typeof(void), typeof(double), c, typeof(double), m, typeof(double), y, typeof(double), k, typeof(double), a);
        }
        public void SetCmykF(double c, double m, double y, double k) {
            interceptor.Invoke("setCmykF$$$$", "setCmykF(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), c, typeof(double), m, typeof(double), y, typeof(double), k);
        }
        public int HslHue() {
            return (int) interceptor.Invoke("hslHue", "hslHue() const", typeof(int));
        }
        public int HslSaturation() {
            return (int) interceptor.Invoke("hslSaturation", "hslSaturation() const", typeof(int));
        }
        public int Lightness() {
            return (int) interceptor.Invoke("lightness", "lightness() const", typeof(int));
        }
        public double HslHueF() {
            return (double) interceptor.Invoke("hslHueF", "hslHueF() const", typeof(double));
        }
        public double HslSaturationF() {
            return (double) interceptor.Invoke("hslSaturationF", "hslSaturationF() const", typeof(double));
        }
        public double LightnessF() {
            return (double) interceptor.Invoke("lightnessF", "lightnessF() const", typeof(double));
        }
        public void GetHsl(ref int h, ref int s, ref int l, ref int a) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = h;
            stack[2].s_int = s;
            stack[3].s_int = l;
            stack[4].s_int = a;
            interceptor.Invoke("getHsl$$$$", "getHsl(int*, int*, int*, int*) const", stack);
            h = stack[1].s_int;
            s = stack[2].s_int;
            l = stack[3].s_int;
            a = stack[4].s_int;
            return;
        }
        public void GetHsl(ref int h, ref int s, ref int l) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_int = h;
            stack[2].s_int = s;
            stack[3].s_int = l;
            interceptor.Invoke("getHsl$$$", "getHsl(int*, int*, int*) const", stack);
            h = stack[1].s_int;
            s = stack[2].s_int;
            l = stack[3].s_int;
            return;
        }
        public void SetHsl(int h, int s, int l, int a) {
            interceptor.Invoke("setHsl$$$$", "setHsl(int, int, int, int)", typeof(void), typeof(int), h, typeof(int), s, typeof(int), l, typeof(int), a);
        }
        public void SetHsl(int h, int s, int l) {
            interceptor.Invoke("setHsl$$$", "setHsl(int, int, int)", typeof(void), typeof(int), h, typeof(int), s, typeof(int), l);
        }
        public void GetHslF(ref double h, ref double s, ref double l, ref double a) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_double = h;
            stack[2].s_double = s;
            stack[3].s_double = l;
            stack[4].s_double = a;
            interceptor.Invoke("getHslF$$$$", "getHslF(qreal*, qreal*, qreal*, qreal*) const", stack);
            h = stack[1].s_double;
            s = stack[2].s_double;
            l = stack[3].s_double;
            a = stack[4].s_double;
            return;
        }
        public void GetHslF(ref double h, ref double s, ref double l) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_double = h;
            stack[2].s_double = s;
            stack[3].s_double = l;
            interceptor.Invoke("getHslF$$$", "getHslF(qreal*, qreal*, qreal*) const", stack);
            h = stack[1].s_double;
            s = stack[2].s_double;
            l = stack[3].s_double;
            return;
        }
        public void SetHslF(double h, double s, double l, double a) {
            interceptor.Invoke("setHslF$$$$", "setHslF(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), h, typeof(double), s, typeof(double), l, typeof(double), a);
        }
        public void SetHslF(double h, double s, double l) {
            interceptor.Invoke("setHslF$$$", "setHslF(qreal, qreal, qreal)", typeof(void), typeof(double), h, typeof(double), s, typeof(double), l);
        }
        public QColor ToRgb() {
            return (QColor) interceptor.Invoke("toRgb", "toRgb() const", typeof(QColor));
        }
        public QColor ToHsv() {
            return (QColor) interceptor.Invoke("toHsv", "toHsv() const", typeof(QColor));
        }
        public QColor ToCmyk() {
            return (QColor) interceptor.Invoke("toCmyk", "toCmyk() const", typeof(QColor));
        }
        public QColor ToHsl() {
            return (QColor) interceptor.Invoke("toHsl", "toHsl() const", typeof(QColor));
        }
        public QColor ConvertTo(QColor.Spec colorSpec) {
            return (QColor) interceptor.Invoke("convertTo$", "convertTo(QColor::Spec) const", typeof(QColor), typeof(QColor.Spec), colorSpec);
        }
        public QColor Light(int f) {
            return (QColor) interceptor.Invoke("light$", "light(int) const", typeof(QColor), typeof(int), f);
        }
        public QColor Light() {
            return (QColor) interceptor.Invoke("light", "light() const", typeof(QColor));
        }
        public QColor Lighter(int f) {
            return (QColor) interceptor.Invoke("lighter$", "lighter(int) const", typeof(QColor), typeof(int), f);
        }
        public QColor Lighter() {
            return (QColor) interceptor.Invoke("lighter", "lighter() const", typeof(QColor));
        }
        public QColor Dark(int f) {
            return (QColor) interceptor.Invoke("dark$", "dark(int) const", typeof(QColor), typeof(int), f);
        }
        public QColor Dark() {
            return (QColor) interceptor.Invoke("dark", "dark() const", typeof(QColor));
        }
        public QColor Darker(int f) {
            return (QColor) interceptor.Invoke("darker$", "darker(int) const", typeof(QColor), typeof(int), f);
        }
        public QColor Darker() {
            return (QColor) interceptor.Invoke("darker", "darker() const", typeof(QColor));
        }
        public override bool Equals(object o) {
            if (!(o is QColor)) { return false; }
            return this == (QColor) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        ~QColor() {
            interceptor.Invoke("~QColor", "~QColor()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QColor", "~QColor()", typeof(void));
        }
        public static bool operator==(QColor lhs, QColor c) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QColor&) const", typeof(bool), typeof(QColor), lhs, typeof(QColor), c);
        }
        public static bool operator!=(QColor lhs, QColor c) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QColor&) const", typeof(bool), typeof(QColor), lhs, typeof(QColor), c);
        }
        public static QVariant operatorQVariant(QColor lhs) {
            return (QVariant) staticInterceptor.Invoke("operator QVariant", "operator QVariant() const", typeof(QVariant), typeof(QColor), lhs);
        }
        public static List<string> ColorNames() {
            return (List<string>) staticInterceptor.Invoke("colorNames", "colorNames()", typeof(List<string>));
        }
        public static QColor FromRgb(uint rgb) {
            return (QColor) staticInterceptor.Invoke("fromRgb$", "fromRgb(unsigned int)", typeof(QColor), typeof(uint), rgb);
        }
        public static QColor FromRgba(uint rgba) {
            return (QColor) staticInterceptor.Invoke("fromRgba$", "fromRgba(unsigned int)", typeof(QColor), typeof(uint), rgba);
        }
        public static QColor FromRgb(int r, int g, int b, int a) {
            return (QColor) staticInterceptor.Invoke("fromRgb$$$$", "fromRgb(int, int, int, int)", typeof(QColor), typeof(int), r, typeof(int), g, typeof(int), b, typeof(int), a);
        }
        public static QColor FromRgb(int r, int g, int b) {
            return (QColor) staticInterceptor.Invoke("fromRgb$$$", "fromRgb(int, int, int)", typeof(QColor), typeof(int), r, typeof(int), g, typeof(int), b);
        }
        public static QColor FromRgbF(double r, double g, double b, double a) {
            return (QColor) staticInterceptor.Invoke("fromRgbF$$$$", "fromRgbF(qreal, qreal, qreal, qreal)", typeof(QColor), typeof(double), r, typeof(double), g, typeof(double), b, typeof(double), a);
        }
        public static QColor FromRgbF(double r, double g, double b) {
            return (QColor) staticInterceptor.Invoke("fromRgbF$$$", "fromRgbF(qreal, qreal, qreal)", typeof(QColor), typeof(double), r, typeof(double), g, typeof(double), b);
        }
        public static QColor FromHsv(int h, int s, int v, int a) {
            return (QColor) staticInterceptor.Invoke("fromHsv$$$$", "fromHsv(int, int, int, int)", typeof(QColor), typeof(int), h, typeof(int), s, typeof(int), v, typeof(int), a);
        }
        public static QColor FromHsv(int h, int s, int v) {
            return (QColor) staticInterceptor.Invoke("fromHsv$$$", "fromHsv(int, int, int)", typeof(QColor), typeof(int), h, typeof(int), s, typeof(int), v);
        }
        public static QColor FromHsvF(double h, double s, double v, double a) {
            return (QColor) staticInterceptor.Invoke("fromHsvF$$$$", "fromHsvF(qreal, qreal, qreal, qreal)", typeof(QColor), typeof(double), h, typeof(double), s, typeof(double), v, typeof(double), a);
        }
        public static QColor FromHsvF(double h, double s, double v) {
            return (QColor) staticInterceptor.Invoke("fromHsvF$$$", "fromHsvF(qreal, qreal, qreal)", typeof(QColor), typeof(double), h, typeof(double), s, typeof(double), v);
        }
        public static QColor FromCmyk(int c, int m, int y, int k, int a) {
            return (QColor) staticInterceptor.Invoke("fromCmyk$$$$$", "fromCmyk(int, int, int, int, int)", typeof(QColor), typeof(int), c, typeof(int), m, typeof(int), y, typeof(int), k, typeof(int), a);
        }
        public static QColor FromCmyk(int c, int m, int y, int k) {
            return (QColor) staticInterceptor.Invoke("fromCmyk$$$$", "fromCmyk(int, int, int, int)", typeof(QColor), typeof(int), c, typeof(int), m, typeof(int), y, typeof(int), k);
        }
        public static QColor FromCmykF(double c, double m, double y, double k, double a) {
            return (QColor) staticInterceptor.Invoke("fromCmykF$$$$$", "fromCmykF(qreal, qreal, qreal, qreal, qreal)", typeof(QColor), typeof(double), c, typeof(double), m, typeof(double), y, typeof(double), k, typeof(double), a);
        }
        public static QColor FromCmykF(double c, double m, double y, double k) {
            return (QColor) staticInterceptor.Invoke("fromCmykF$$$$", "fromCmykF(qreal, qreal, qreal, qreal)", typeof(QColor), typeof(double), c, typeof(double), m, typeof(double), y, typeof(double), k);
        }
        public static QColor FromHsl(int h, int s, int l, int a) {
            return (QColor) staticInterceptor.Invoke("fromHsl$$$$", "fromHsl(int, int, int, int)", typeof(QColor), typeof(int), h, typeof(int), s, typeof(int), l, typeof(int), a);
        }
        public static QColor FromHsl(int h, int s, int l) {
            return (QColor) staticInterceptor.Invoke("fromHsl$$$", "fromHsl(int, int, int)", typeof(QColor), typeof(int), h, typeof(int), s, typeof(int), l);
        }
        public static QColor FromHslF(double h, double s, double l, double a) {
            return (QColor) staticInterceptor.Invoke("fromHslF$$$$", "fromHslF(qreal, qreal, qreal, qreal)", typeof(QColor), typeof(double), h, typeof(double), s, typeof(double), l, typeof(double), a);
        }
        public static QColor FromHslF(double h, double s, double l) {
            return (QColor) staticInterceptor.Invoke("fromHslF$$$", "fromHslF(qreal, qreal, qreal)", typeof(QColor), typeof(double), h, typeof(double), s, typeof(double), l);
        }
    }
}
