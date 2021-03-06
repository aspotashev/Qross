//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  Creates a widget featuring a KTreeWidgetSearchLine, a label with the text
    ///  "Search" and a button to clear the search.
    ///  </remarks>        <short>    Creates a widget featuring a KTreeWidgetSearchLine, a label with the text  "Search" and a button to clear the search.</short>
    [SmokeClass("KTreeWidgetSearchLineWidget")]
    public class KTreeWidgetSearchLineWidget : QWidget, IDisposable {
        protected KTreeWidgetSearchLineWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTreeWidgetSearchLineWidget), this);
        }
        /// <remarks>
        ///  Creates a KTreeWidgetSearchLineWidget for \a treeWidget with \a parent as the
        ///  parent.
        ///      </remarks>        <short>    Creates a KTreeWidgetSearchLineWidget for \a treeWidget with \a parent as the  parent.</short>
        public KTreeWidgetSearchLineWidget(QWidget parent, QTreeWidget treeWidget) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTreeWidgetSearchLineWidget##", "KTreeWidgetSearchLineWidget(QWidget*, QTreeWidget*)", typeof(void), typeof(QWidget), parent, typeof(QTreeWidget), treeWidget);
        }
        public KTreeWidgetSearchLineWidget(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTreeWidgetSearchLineWidget#", "KTreeWidgetSearchLineWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KTreeWidgetSearchLineWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTreeWidgetSearchLineWidget", "KTreeWidgetSearchLineWidget()", typeof(void));
        }
        /// <remarks>
        ///  Returns a pointer to the search line.
        ///      </remarks>        <short>    Returns a pointer to the search line.</short>
        public KTreeWidgetSearchLine SearchLine() {
            return (KTreeWidgetSearchLine) interceptor.Invoke("searchLine", "searchLine() const", typeof(KTreeWidgetSearchLine));
        }
        /// <remarks>
        ///  Creates the search line.  This can be useful to reimplement in cases where
        ///  a KTreeWidgetSearchLine subclass is used.
        ///  It is const because it is be called from searchLine(), which to the user
        ///  doesn't conceptually alter the widget.
        ///      </remarks>        <short>    Creates the search line.</short>
        [SmokeMethod("createSearchLine(QTreeWidget*) const")]
        protected virtual KTreeWidgetSearchLine CreateSearchLine(QTreeWidget treeWidget) {
            return (KTreeWidgetSearchLine) interceptor.Invoke("createSearchLine#", "createSearchLine(QTreeWidget*) const", typeof(KTreeWidgetSearchLine), typeof(QTreeWidget), treeWidget);
        }
        /// <remarks>
        ///  Creates the widgets inside of the widget.  This is called from the
        ///  constructor via a single shot timer so that it it guaranteed to run
        ///  after construction is complete.  This makes it suitable for overriding in
        ///  subclasses.
        ///      </remarks>        <short>    Creates the widgets inside of the widget.</short>
        [Q_SLOT("void createWidgets()")]
        [SmokeMethod("createWidgets()")]
        protected virtual void CreateWidgets() {
            interceptor.Invoke("createWidgets", "createWidgets()", typeof(void));
        }
        ~KTreeWidgetSearchLineWidget() {
            interceptor.Invoke("~KTreeWidgetSearchLineWidget", "~KTreeWidgetSearchLineWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KTreeWidgetSearchLineWidget", "~KTreeWidgetSearchLineWidget()", typeof(void));
        }
        protected new IKTreeWidgetSearchLineWidgetSignals Emit {
            get { return (IKTreeWidgetSearchLineWidgetSignals) Q_EMIT; }
        }
    }

    public interface IKTreeWidgetSearchLineWidgetSignals : IQWidgetSignals {
    }
}
