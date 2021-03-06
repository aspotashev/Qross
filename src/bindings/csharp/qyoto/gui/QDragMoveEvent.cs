//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QDragMoveEvent")]
    public class QDragMoveEvent : QDropEvent, IDisposable {
        protected QDragMoveEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDragMoveEvent), this);
        }
        public QDragMoveEvent(QPoint pos, uint actions, QMimeData data, uint buttons, uint modifiers, QEvent.TypeOf type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDragMoveEvent#$#$$$", "QDragMoveEvent(const QPoint&, Qt::DropActions, const QMimeData*, Qt::MouseButtons, Qt::KeyboardModifiers, QEvent::Type)", typeof(void), typeof(QPoint), pos, typeof(uint), actions, typeof(QMimeData), data, typeof(uint), buttons, typeof(uint), modifiers, typeof(QEvent.TypeOf), type);
        }
        public QDragMoveEvent(QPoint pos, uint actions, QMimeData data, uint buttons, uint modifiers) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDragMoveEvent#$#$$", "QDragMoveEvent(const QPoint&, Qt::DropActions, const QMimeData*, Qt::MouseButtons, Qt::KeyboardModifiers)", typeof(void), typeof(QPoint), pos, typeof(uint), actions, typeof(QMimeData), data, typeof(uint), buttons, typeof(uint), modifiers);
        }
        public QRect AnswerRect() {
            return (QRect) interceptor.Invoke("answerRect", "answerRect() const", typeof(QRect));
        }
        public new void Accept() {
            interceptor.Invoke("accept", "accept()", typeof(void));
        }
        public new void Ignore() {
            interceptor.Invoke("ignore", "ignore()", typeof(void));
        }
        public void Accept(QRect r) {
            interceptor.Invoke("accept#", "accept(const QRect&)", typeof(void), typeof(QRect), r);
        }
        public void Ignore(QRect r) {
            interceptor.Invoke("ignore#", "ignore(const QRect&)", typeof(void), typeof(QRect), r);
        }
        ~QDragMoveEvent() {
            interceptor.Invoke("~QDragMoveEvent", "~QDragMoveEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDragMoveEvent", "~QDragMoveEvent()", typeof(void));
        }
    }
}
