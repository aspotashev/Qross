//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class KPlotObject
    ///  Think of a KPlotObject as a set of data displayed as a group in the plot.
    ///  Each KPlotObject consists of a list of KPlotPoints, a "type" controlling 
    ///  how the data points are displayed (some combination of Points, Lines, or
    ///  Bars), a color, and a size. There is also a parameter which controls the
    ///  shape of the points used to display the KPlotObject.
    ///  @note KPlotObject will take care of the points added to it, so when clearing
    ///  the points list (eg with clearPoints()) any previous reference to a KPlotPoint
    ///  already added to a KPlotObject will be invalid.
    /// </remarks>        <author> Jason Harris
    /// </author>
    ///         <version> 1.1
    ///  </version>
    ///         <short> Encapsulates a data set to be plotted in a KPlotWidget. </short>
    [SmokeClass("KPlotObject")]
    public class KPlotObject : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KPlotObject(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KPlotObject), this);
        }
        /// <remarks>
        ///  The type classification of the KPlotObject.
        ///  These are bitmask values that can be OR'd together, so that a set
        ///  of points can be represented in the plot in multiple ways.
        ///  @note points should be added in order of increasing x-coordinate
        ///  when using Bars.
        ///      </remarks>        <short>    The type classification of the KPlotObject.</short>
        public enum PlotType {
            UnknownType = 0,
            Points = 1,
            Lines = 2,
            Bars = 4,
        }
        /// <remarks>
        ///  The available shape styles for plotted points.
        ///      </remarks>        <short>    The available shape styles for plotted points.</short>
        public enum PointStyle {
            NoPoints = 0,
            Circle = 1,
            Letter = 2,
            Triangle = 3,
            Square = 4,
            Pentagon = 5,
            Hexagon = 6,
            Asterisk = 7,
            Star = 8,
            UnknwonPoint = 9,
        }
        /// <remarks>
        ///  Constructor.
        /// <param> name="color" The color for plotting this object. By default this sets
        ///  the color for Points, Lines and Bars, but there are functions to
        ///  override any of these.
        /// </param><param> name="otype" the PlotType for this object (Points, Lines or Bars)
        /// </param><param> name="size" the size to use for plotted points, in pixels
        /// </param><param> name="ps" The PointStyle describing the shape for plotted points
        ///      </param></remarks>        <short>    Constructor.</short>
        public KPlotObject(QColor color, KPlotObject.PlotType otype, double size, KPlotObject.PointStyle ps) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotObject#$$$", "KPlotObject(const QColor&, KPlotObject::PlotType, double, KPlotObject::PointStyle)", typeof(void), typeof(QColor), color, typeof(KPlotObject.PlotType), otype, typeof(double), size, typeof(KPlotObject.PointStyle), ps);
        }
        public KPlotObject(QColor color, KPlotObject.PlotType otype, double size) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotObject#$$", "KPlotObject(const QColor&, KPlotObject::PlotType, double)", typeof(void), typeof(QColor), color, typeof(KPlotObject.PlotType), otype, typeof(double), size);
        }
        public KPlotObject(QColor color, KPlotObject.PlotType otype) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotObject#$", "KPlotObject(const QColor&, KPlotObject::PlotType)", typeof(void), typeof(QColor), color, typeof(KPlotObject.PlotType), otype);
        }
        public KPlotObject(QColor color) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotObject#", "KPlotObject(const QColor&)", typeof(void), typeof(QColor), color);
        }
        public KPlotObject() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotObject", "KPlotObject()", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> the plot flags of the object
        ///      </return>
        ///         <short>   </short>
        public uint PlotTypes() {
            return (uint) interceptor.Invoke("plotTypes", "plotTypes() const", typeof(uint));
        }
        /// <remarks>
        ///  Set whether points will be drawn for this object
        /// <param> name="b" if true, points will be drawn
        ///      </param></remarks>        <short>    Set whether points will be drawn for this object </short>
        public void SetShowPoints(bool b) {
            interceptor.Invoke("setShowPoints$", "setShowPoints(bool)", typeof(void), typeof(bool), b);
        }
        /// <remarks>
        ///  Set whether lines will be drawn for this object
        /// <param> name="b" if true, lines will be drawn
        ///      </param></remarks>        <short>    Set whether lines will be drawn for this object </short>
        public void SetShowLines(bool b) {
            interceptor.Invoke("setShowLines$", "setShowLines(bool)", typeof(void), typeof(bool), b);
        }
        /// <remarks>
        ///  Set whether bars will be drawn for this object
        /// <param> name="b" if true, bars will be drawn
        ///      </param></remarks>        <short>    Set whether bars will be drawn for this object </short>
        public void SetShowBars(bool b) {
            interceptor.Invoke("setShowBars$", "setShowBars(bool)", typeof(void), typeof(bool), b);
        }
        /// <remarks>
        /// </remarks>        <return> the size of the plotted points in this object, in pixels
        ///      </return>
        ///         <short>   </short>
        public double Size() {
            return (double) interceptor.Invoke("size", "size() const", typeof(double));
        }
        /// <remarks>
        ///  Set the size for plotted points in this object, in pixels
        /// <param> name="s" the new size
        ///      </param></remarks>        <short>    Set the size for plotted points in this object, in pixels </short>
        public void SetSize(double s) {
            interceptor.Invoke("setSize$", "setSize(double)", typeof(void), typeof(double), s);
        }
        /// <remarks>
        /// </remarks>        <return> the style used for drawing the points in this object
        ///      </return>
        ///         <short>   </short>
        public KPlotObject.PointStyle pointStyle() {
            return (KPlotObject.PointStyle) interceptor.Invoke("pointStyle", "pointStyle() const", typeof(KPlotObject.PointStyle));
        }
        /// <remarks>
        ///  Set a new style for drawing the points in this object
        /// <param> name="p" the new style
        ///      </param></remarks>        <short>    Set a new style for drawing the points in this object </short>
        public void SetPointStyle(KPlotObject.PointStyle p) {
            interceptor.Invoke("setPointStyle$", "setPointStyle(KPlotObject::PointStyle)", typeof(void), typeof(KPlotObject.PointStyle), p);
        }
        /// <remarks>
        /// </remarks>        <return> the default pen for this Object.
        ///  If no other pens are set, this pen will be used for 
        ///  points, lines, bars and labels (this pen is always used for points).
        ///      </return>
        ///         <short>   </short>
        public QPen Pen() {
            return (QPen) interceptor.Invoke("pen", "pen() const", typeof(QPen));
        }
        /// <remarks>
        ///  Set the default pen for this object
        ///  <code>The</code> pen to use
        ///      </remarks>        <short>    Set the default pen for this object  <code>The</code> pen to use      </short>
        public void SetPen(QPen p) {
            interceptor.Invoke("setPen#", "setPen(const QPen&)", typeof(void), typeof(QPen), p);
        }
        /// <remarks>
        /// </remarks>        <return> the pen to use for drawing lines for this Object.
        ///      </return>
        ///         <short>   </short>
        public QPen LinePen() {
            return (QPen) interceptor.Invoke("linePen", "linePen() const", typeof(QPen));
        }
        /// <remarks>
        ///  Set the pen to use for drawing lines for this object
        ///  <code>The</code> pen to use
        ///      </remarks>        <short>    Set the pen to use for drawing lines for this object  <code>The</code> pen to use      </short>
        public void SetLinePen(QPen p) {
            interceptor.Invoke("setLinePen#", "setLinePen(const QPen&)", typeof(void), typeof(QPen), p);
        }
        /// <remarks>
        /// </remarks>        <return> the pen to use for drawing bars for this Object.
        ///      </return>
        ///         <short>   </short>
        public QPen BarPen() {
            return (QPen) interceptor.Invoke("barPen", "barPen() const", typeof(QPen));
        }
        /// <remarks>
        ///  Set the pen to use for drawing bars for this object
        ///  <code>The</code> pen to use
        ///      </remarks>        <short>    Set the pen to use for drawing bars for this object  <code>The</code> pen to use      </short>
        public void SetBarPen(QPen p) {
            interceptor.Invoke("setBarPen#", "setBarPen(const QPen&)", typeof(void), typeof(QPen), p);
        }
        /// <remarks>
        /// </remarks>        <return> the pen to use for drawing labels for this Object.
        ///      </return>
        ///         <short>   </short>
        public QPen LabelPen() {
            return (QPen) interceptor.Invoke("labelPen", "labelPen() const", typeof(QPen));
        }
        /// <remarks>
        ///  Set the pen to use for labels for this object
        ///  <code>The</code> pen to use
        ///      </remarks>        <short>    Set the pen to use for labels for this object  <code>The</code> pen to use      </short>
        public void SetLabelPen(QPen p) {
            interceptor.Invoke("setLabelPen#", "setLabelPen(const QPen&)", typeof(void), typeof(QPen), p);
        }
        /// <remarks>
        /// </remarks>        <return> the default Brush to use for this Object.
        ///      </return>
        ///         <short>   </short>
        public QBrush Brush() {
            return (QBrush) interceptor.Invoke("brush", "brush() const", typeof(QBrush));
        }
        /// <remarks>
        ///  Set the default brush to use for this object
        ///  <b></b>he brush to use
        ///      </remarks>        <short>    Set the default brush to use for this object  <b></b>he brush to use      </short>
        public void SetBrush(QBrush b) {
            interceptor.Invoke("setBrush#", "setBrush(const QBrush&)", typeof(void), typeof(QBrush), b);
        }
        /// <remarks>
        /// </remarks>        <return> the brush to use for filling bars for this Object.
        ///      </return>
        ///         <short>   </short>
        public QBrush BarBrush() {
            return (QBrush) interceptor.Invoke("barBrush", "barBrush() const", typeof(QBrush));
        }
        /// <remarks>
        ///  Set the brush to use for drawing bars for this object
        ///  <b></b>he brush to use
        ///      </remarks>        <short>    Set the brush to use for drawing bars for this object  <b></b>he brush to use      </short>
        public void SetBarBrush(QBrush b) {
            interceptor.Invoke("setBarBrush#", "setBarBrush(const QBrush&)", typeof(void), typeof(QBrush), b);
        }
        /// <remarks>
        /// </remarks>        <return> the list of KPlotPoints that make up this object
        ///      </return>
        ///         <short>   </short>
        public List<KPlotPoint> Points() {
            return (List<KPlotPoint>) interceptor.Invoke("points", "points() const", typeof(List<KPlotPoint>));
        }
        /// <remarks>
        ///  Add a point to the object's list of points, using input data to construct a KPlotPoint.
        /// <param> name="p" the QPointF to add.
        /// </param><param> name="label" the optional text label for this point
        /// </param><param> name="barWidth" the width of the bar, if this object is to be drawn with bars
        ///  @note if @param barWidth is left at its default value of 0.0, then the width will be 
        ///  automatically set to the distance between this point and the one to its right.
        ///      </param></remarks>        <short>    Add a point to the object's list of points, using input data to construct a KPlotPoint.</short>
        public void AddPoint(QPointF p, string label, double barWidth) {
            interceptor.Invoke("addPoint#$$", "addPoint(const QPointF&, const QString&, double)", typeof(void), typeof(QPointF), p, typeof(string), label, typeof(double), barWidth);
        }
        public void AddPoint(QPointF p, string label) {
            interceptor.Invoke("addPoint#$", "addPoint(const QPointF&, const QString&)", typeof(void), typeof(QPointF), p, typeof(string), label);
        }
        public void AddPoint(QPointF p) {
            interceptor.Invoke("addPoint#", "addPoint(const QPointF&)", typeof(void), typeof(QPointF), p);
        }
        /// <remarks>
        ///  Add a given KPlotPoint to the object's list of points.
        ///  @overload
        /// <param> name="p" pointer to the KPlotPoint to add.
        ///      </param></remarks>        <short>    Add a given KPlotPoint to the object's list of points.</short>
        public void AddPoint(KPlotPoint p) {
            interceptor.Invoke("addPoint#", "addPoint(KPlotPoint*)", typeof(void), typeof(KPlotPoint), p);
        }
        /// <remarks>
        ///  Add a point to the object's list of points, using input data to construct a KPlotPoint.
        ///  @overload
        /// <param> name="x" the X-coordinate of the point to add.
        /// </param><param> name="y" the Y-coordinate of the point to add.
        /// </param><param> name="label" the optional text label
        /// </param><param> name="barWidth" the width of the bar, if this object is to be drawn with bars
        ///  @note if @param barWidth is left at its default value of 0.0, then the width will be 
        ///  automatically set to the distance between this point and the one to its right.
        ///      </param></remarks>        <short>    Add a point to the object's list of points, using input data to construct a KPlotPoint.</short>
        public void AddPoint(double x, double y, string label, double barWidth) {
            interceptor.Invoke("addPoint$$$$", "addPoint(double, double, const QString&, double)", typeof(void), typeof(double), x, typeof(double), y, typeof(string), label, typeof(double), barWidth);
        }
        public void AddPoint(double x, double y, string label) {
            interceptor.Invoke("addPoint$$$", "addPoint(double, double, const QString&)", typeof(void), typeof(double), x, typeof(double), y, typeof(string), label);
        }
        public void AddPoint(double x, double y) {
            interceptor.Invoke("addPoint$$", "addPoint(double, double)", typeof(void), typeof(double), x, typeof(double), y);
        }
        /// <remarks>
        ///  Remove the QPointF at position index from the list of points
        /// <param> name="index" the index of the point to be removed.
        ///      </param></remarks>        <short>    Remove the QPointF at position index from the list of points </short>
        public void RemovePoint(int index) {
            interceptor.Invoke("removePoint$", "removePoint(int)", typeof(void), typeof(int), index);
        }
        /// <remarks>
        ///  Remove and destroy the points of this object
        ///      </remarks>        <short>    Remove and destroy the points of this object      </short>
        public void ClearPoints() {
            interceptor.Invoke("clearPoints", "clearPoints()", typeof(void));
        }
        /// <remarks>
        ///  Draw this KPlotObject on the given QPainter
        /// <param> name="p" The QPainter to draw on
        /// </param><param> name="pw" the KPlotWidget to draw on (this is needed 
        ///  for the KPlotWidget.MapToWidget() function)
        ///      </param></remarks>        <short>    Draw this KPlotObject on the given QPainter </short>
        public void Draw(QPainter p, KPlotWidget pw) {
            interceptor.Invoke("draw##", "draw(QPainter*, KPlotWidget*)", typeof(void), typeof(QPainter), p, typeof(KPlotWidget), pw);
        }
        ~KPlotObject() {
            interceptor.Invoke("~KPlotObject", "~KPlotObject()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KPlotObject", "~KPlotObject()", typeof(void));
        }
    }
}
