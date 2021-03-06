//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  This class implements the "delayed-mimetype-determination" feature,
    ///  for directory views.
    ///  It determines the mimetypes of the icons in the background, but giving
    ///  preferrence to the visible icons.
    ///  </remarks>        <short>    This class implements the "delayed-mimetype-determination" feature,  for directory views.</short>
    [SmokeClass("KMimeTypeResolver")]
    public class KMimeTypeResolver : QObject, IDisposable {
        protected KMimeTypeResolver(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KMimeTypeResolver), this);
        }
        /// <remarks>
        ///  The mimetype resolver is made a child of the view.
        ///  It is OK to have one resolver per view, and have those views share a common model;
        ///  this way the mimetypes will only be determined once per item in the model, which saves time.
        ///  WARNING: if you call KDirModel.SetDirLister, do it before creating the KMimeTypeResolver
        ///  If this is a problem, tell me and I'll add a signal...
        ///      </remarks>        <short>    The mimetype resolver is made a child of the view.</short>
        public KMimeTypeResolver(QAbstractItemView view, KDirModel model) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KMimeTypeResolver##", "KMimeTypeResolver(QAbstractItemView*, KDirModel*)", typeof(void), typeof(QAbstractItemView), view, typeof(KDirModel), model);
        }
        ~KMimeTypeResolver() {
            interceptor.Invoke("~KMimeTypeResolver", "~KMimeTypeResolver()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KMimeTypeResolver", "~KMimeTypeResolver()", typeof(void));
        }
        protected new IKMimeTypeResolverSignals Emit {
            get { return (IKMimeTypeResolverSignals) Q_EMIT; }
        }
    }

    public interface IKMimeTypeResolverSignals : IQObjectSignals {
    }
}
