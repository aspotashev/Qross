//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///   See <see cref="ISkipDialogSignals"></see> for signals emitted by SkipDialog
    /// </remarks>        <short>   </short>
    [SmokeClass("KIO::SkipDialog")]
    public class SkipDialog : KDialog, IDisposable {
        protected SkipDialog(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(SkipDialog), this);
        }
        public SkipDialog(QWidget parent, bool _multi, string _error_text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("SkipDialog#$$", "SkipDialog(QWidget*, bool, const QString&)", typeof(void), typeof(QWidget), parent, typeof(bool), _multi, typeof(string), _error_text);
        }
        ~SkipDialog() {
            interceptor.Invoke("~SkipDialog", "~SkipDialog()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~SkipDialog", "~SkipDialog()", typeof(void));
        }
        protected new ISkipDialogSignals Emit {
            get { return (ISkipDialogSignals) Q_EMIT; }
        }
    }

    public interface ISkipDialogSignals : IKDialogSignals {
        [Q_SIGNAL("void result(SkipDialog*, int)")]
        void Result(KIO.SkipDialog _this, int _button);
    }
}
