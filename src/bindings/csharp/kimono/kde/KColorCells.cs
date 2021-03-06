//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  A table of editable color cells.
    ///  See <see cref="IKColorCellsSignals"></see> for signals emitted by KColorCells
    /// </remarks>        <author> Martin Jones <mjones@kde.org>
    /// </author>
    ///         <short>    A table of editable color cells.</short>
    [SmokeClass("KColorCells")]
    public class KColorCells : QTableWidget, IDisposable {
        protected KColorCells(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KColorCells), this);
        }
        /// <remarks> 
        ///  Constructs a new table of color cells, consisting of
        ///  <code>rows</code>  <code>columns</code> colors. 
        /// <param> name="parent" The parent of the new widget
        /// </param><param> name="rows" The number of rows in the table
        /// </param><param> name="columns" The number of columns in the table
        ///    </param></remarks>        <short>     Constructs a new table of color cells, consisting of  <code>rows</code>   <code>columns</code> colors.</short>
        public KColorCells(QWidget parent, int rows, int columns) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KColorCells#$$", "KColorCells(QWidget*, int, int)", typeof(void), typeof(QWidget), parent, typeof(int), rows, typeof(int), columns);
        }
        /// <remarks> Sets the color in the given index in the table </remarks>        <short>   Sets the color in the given index in the table </short>
        public void SetColor(int index, QColor col) {
            interceptor.Invoke("setColor$#", "setColor(int, const QColor&)", typeof(void), typeof(int), index, typeof(QColor), col);
        }
        /// <remarks> Returns the color at a given index in the table </remarks>        <short>   Returns the color at a given index in the table </short>
        public QColor Color(int index) {
            return (QColor) interceptor.Invoke("color$", "color(int) const", typeof(QColor), typeof(int), index);
        }
        /// <remarks> Returns the total number of color cells in the table </remarks>        <short>   Returns the total number of color cells in the table </short>
        public int Count() {
            return (int) interceptor.Invoke("count", "count() const", typeof(int));
        }
        public void SetShading(bool shade) {
            interceptor.Invoke("setShading$", "setShading(bool)", typeof(void), typeof(bool), shade);
        }
        public void SetAcceptDrags(bool acceptDrags) {
            interceptor.Invoke("setAcceptDrags$", "setAcceptDrags(bool)", typeof(void), typeof(bool), acceptDrags);
        }
        /// <remarks> Sets the currently selected cell to <code>index</code> </remarks>        <short>   Sets the currently selected cell to <code>index</code> </short>
        public void SetSelected(int index) {
            interceptor.Invoke("setSelected$", "setSelected(int)", typeof(void), typeof(int), index);
        }
        /// <remarks> Returns the index of the cell which is currently selected </remarks>        <short>   Returns the index of the cell which is currently selected </short>
        public int SelectedIndex() {
            return (int) interceptor.Invoke("selectedIndex", "selectedIndex() const", typeof(int));
        }
        [SmokeMethod("sizeHintForColumn(int) const")]
        protected override int SizeHintForColumn(int column) {
            return (int) interceptor.Invoke("sizeHintForColumn$", "sizeHintForColumn(int) const", typeof(int), typeof(int), column);
        }
        [SmokeMethod("sizeHintForRow(int) const")]
        protected override int SizeHintForRow(int column) {
            return (int) interceptor.Invoke("sizeHintForRow$", "sizeHintForRow(int) const", typeof(int), typeof(int), column);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
        }
        [SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
        protected override void MouseReleaseEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("mousePressEvent(QMouseEvent*)")]
        protected override void MousePressEvent(QMouseEvent arg1) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
        protected override void MouseMoveEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
        protected override void DragEnterEvent(QDragEnterEvent arg1) {
            interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QDragEnterEvent*)", typeof(void), typeof(QDragEnterEvent), arg1);
        }
        [SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
        protected override void DragMoveEvent(QDragMoveEvent arg1) {
            interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), arg1);
        }
        [SmokeMethod("dropEvent(QDropEvent*)")]
        protected override void DropEvent(QDropEvent arg1) {
            interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
        }
        [SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
        protected override void MouseDoubleClickEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        protected int PositionToCell(QPoint pos, bool ignoreBorders) {
            return (int) interceptor.Invoke("positionToCell#$", "positionToCell(const QPoint&, bool) const", typeof(int), typeof(QPoint), pos, typeof(bool), ignoreBorders);
        }
        protected int PositionToCell(QPoint pos) {
            return (int) interceptor.Invoke("positionToCell#", "positionToCell(const QPoint&) const", typeof(int), typeof(QPoint), pos);
        }
        ~KColorCells() {
            interceptor.Invoke("~KColorCells", "~KColorCells()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KColorCells", "~KColorCells()", typeof(void));
        }
        protected new IKColorCellsSignals Emit {
            get { return (IKColorCellsSignals) Q_EMIT; }
        }
    }

    public interface IKColorCellsSignals : IQTableWidgetSignals {
        /// <remarks> Emitted when a color is selected in the table </remarks>        <short>   Emitted when a color is selected in the table </short>
        [Q_SIGNAL("void colorSelected(int, QColor)")]
        void ColorSelected(int index, QColor color);
        /// <remarks> Emitted when a color in the table is double-clicked </remarks>        <short>   Emitted when a color in the table is double-clicked </short>
        [Q_SIGNAL("void colorDoubleClicked(int, QColor)")]
        void ColorDoubleClicked(int index, QColor color);
    }
}
