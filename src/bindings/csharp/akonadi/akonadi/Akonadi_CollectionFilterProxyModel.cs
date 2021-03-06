//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  This class can be used on top of a CollectionModel to filter out
    ///  all collections that doesn't match a given mime type.
    ///  For instance, a mail application will use addMimeType( "message/rfc822" ) to only show
    ///  collections containing mail.
    ///  @code
    ///    Akonadi.CollectionModel model = new Akonadi.CollectionModel( this );
    ///    Akonadi.CollectionFilterProxy proxy = new Akonadi.CollectionFilterProxyModel();
    ///    proxy.AddMimeTypeFilter( "message/rfc822" );
    ///    proxy.SetSourceModel( model );
    ///    QTreeView view = new QTreeView( this );
    ///    view.SetModel( proxy );
    ///  @endcode
    /// </remarks>        <author> Bruno Virlet <bruno.virlet@gmail.com>
    ///  </author>
    ///         <short> A proxy model that filters collections by mime type. </short>
    [SmokeClass("Akonadi::CollectionFilterProxyModel")]
    public class CollectionFilterProxyModel : QSortFilterProxyModel, IDisposable {
        protected CollectionFilterProxyModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(CollectionFilterProxyModel), this);
        }
        /// <remarks>
        ///  Creates a new collection proxy filter model.
        /// <param> name="parent" The parent object.
        ///      </param></remarks>        <short>    Creates a new collection proxy filter model.</short>
        public CollectionFilterProxyModel(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("CollectionFilterProxyModel#", "CollectionFilterProxyModel(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public CollectionFilterProxyModel() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("CollectionFilterProxyModel", "CollectionFilterProxyModel()", typeof(void));
        }
        /// <remarks>
        ///  Add mime types to be shown by the filter.
        /// <param> name="mimeTypes" A list of mime types to be shown.
        ///      </param></remarks>        <short>    Add mime types to be shown by the filter.</short>
        public void AddMimeTypeFilters(List<string> mimeTypes) {
            interceptor.Invoke("addMimeTypeFilters?", "addMimeTypeFilters(const QStringList&)", typeof(void), typeof(List<string>), mimeTypes);
        }
        /// <remarks>
        ///  Add mime type to be shown by the filter.
        /// <param> name="mimeType" A mime type to be shown.
        ///      </param></remarks>        <short>    Add mime type to be shown by the filter.</short>
        public void AddMimeTypeFilter(string mimeType) {
            interceptor.Invoke("addMimeTypeFilter$", "addMimeTypeFilter(const QString&)", typeof(void), typeof(string), mimeType);
        }
        /// <remarks>
        ///  Returns the list of mime type filters.
        ///      </remarks>        <short>    Returns the list of mime type filters.</short>
        public List<string> MimeTypeFilters() {
            return (List<string>) interceptor.Invoke("mimeTypeFilters", "mimeTypeFilters() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Clear all mime type filters.
        ///      </remarks>        <short>    Clear all mime type filters.</short>
        public void ClearFilters() {
            interceptor.Invoke("clearFilters", "clearFilters()", typeof(void));
        }
        [SmokeMethod("filterAcceptsRow(int, const QModelIndex&) const")]
        protected override bool FilterAcceptsRow(int sourceRow, QModelIndex sourceParent) {
            return (bool) interceptor.Invoke("filterAcceptsRow$#", "filterAcceptsRow(int, const QModelIndex&) const", typeof(bool), typeof(int), sourceRow, typeof(QModelIndex), sourceParent);
        }
        ~CollectionFilterProxyModel() {
            interceptor.Invoke("~CollectionFilterProxyModel", "~CollectionFilterProxyModel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~CollectionFilterProxyModel", "~CollectionFilterProxyModel()", typeof(void));
        }
        protected new ICollectionFilterProxyModelSignals Emit {
            get { return (ICollectionFilterProxyModelSignals) Q_EMIT; }
        }
    }

    public interface ICollectionFilterProxyModelSignals : IQSortFilterProxyModelSignals {
    }
}
