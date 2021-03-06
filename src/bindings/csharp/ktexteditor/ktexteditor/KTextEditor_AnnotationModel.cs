//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \brief An model for providing line annotation information
    ///  \section annomodel_intro Introduction
    ///  AnnotationModel is a model-like interface that can be implemented
    ///  to provide annotation information for each line in a document. It provides
    ///  means to retrieve several kinds of data for a given line in the document.
    ///  \section annomodel_impl Implementing a AnnotationModel
    ///  The public interface of this class is loosely based on the QAbstractItemModel
    ///  interfaces. It only has a single method to override which is the \ref data()
    ///  method to provide the actual data for a line and role combination.
    ///  \since 4.1
    ///  \see KTextEditor.AnnotationInterface, KTextEditor.AnnotationViewInterface
    ///   See <see cref="IAnnotationModelSignals"></see> for signals emitted by AnnotationModel
    /// </remarks>        <short>    \brief An model for providing line annotation information </short>
    [SmokeClass("KTextEditor::AnnotationModel")]
    public class AnnotationModel : QObject, IDisposable {
        protected AnnotationModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(AnnotationModel), this);
        }
        /// <remarks>
        ///  data() is used to retrieve the information needed to present the
        ///  annotation information from the annotation model. The provider
        ///  should return useful information for the line and the data role.
        ///  \param line the line for which the data is to be retrieved
        ///  \param role the role to identify which kind of annotation is to be retrieved
        ///  \returns a \ref QVariant that contains the data for the given role. The
        ///  following roles are supported:
        ///  \ref Qt.DisplayRole - a short display text to be placed in the border
        ///  \ref Qt.TooltipRole - a tooltip information, longer text possible
        ///  \ref Qt.BackgroundRole - a brush to be used to paint the background on the border
        ///  \ref Qt.ForegroundRole - a brush to be used to paint the text on the border
        ///      </remarks>        <short>    data() is used to retrieve the information needed to present the  annotation information from the annotation model.</short>
        [SmokeMethod("data(int, Qt::ItemDataRole) const")]
        public virtual QVariant Data(int line, Qt.ItemDataRole role) {
            return (QVariant) interceptor.Invoke("data$$", "data(int, Qt::ItemDataRole) const", typeof(QVariant), typeof(int), line, typeof(Qt.ItemDataRole), role);
        }
        public AnnotationModel() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AnnotationModel", "AnnotationModel()", typeof(void));
        }
        ~AnnotationModel() {
            interceptor.Invoke("~AnnotationModel", "~AnnotationModel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~AnnotationModel", "~AnnotationModel()", typeof(void));
        }
        protected new IAnnotationModelSignals Emit {
            get { return (IAnnotationModelSignals) Q_EMIT; }
        }
    }

    public interface IAnnotationModelSignals : IQObjectSignals {
        /// <remarks>
        ///  The model should emit the signal reset() when the text of almost all
        ///  lines changes. In most cases it is enough to call lineChanged().
        ///  <b>Note:<> Kate Part implementation details: Whenever reset() is emitted Kate
        ///        Part iterates over all lines of the document. Kate Part searches
        ///        for the longest text to determine the annotation border's width.
        ///  \see lineChanged()
        ///      </remarks>        <short>    The model should emit the signal reset() when the text of almost all  lines changes.</short>
        [Q_SIGNAL("void reset()")]
        void Reset();
        /// <remarks>
        ///  The model should emit the signal lineChanged() when a line has to be
        ///  updated.
        ///  <b>Note:<> Kate Part implementation details: lineChanged() repaints the whole
        ///        annotation border automatically.
        ///      </remarks>        <short>    The model should emit the signal lineChanged() when a line has to be  updated.</short>
        [Q_SIGNAL("void lineChanged(int)")]
        void LineChanged(int line);
    }
}
