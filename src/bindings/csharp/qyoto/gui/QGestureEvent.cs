//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QGestureEvent")]
    public class QGestureEvent : QEvent, IDisposable {
        protected QGestureEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGestureEvent), this);
        }
        public QGestureEvent(List<QGesture> gestures) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGestureEvent?", "QGestureEvent(const QList<QGesture*>&)", typeof(void), typeof(List<QGesture>), gestures);
        }
        public List<QGesture> Gestures() {
            return (List<QGesture>) interceptor.Invoke("gestures", "gestures() const", typeof(List<QGesture>));
        }
        public QGesture Gesture(Qt.GestureType type) {
            return (QGesture) interceptor.Invoke("gesture$", "gesture(Qt::GestureType) const", typeof(QGesture), typeof(Qt.GestureType), type);
        }
        public List<QGesture> ActiveGestures() {
            return (List<QGesture>) interceptor.Invoke("activeGestures", "activeGestures() const", typeof(List<QGesture>));
        }
        public List<QGesture> CanceledGestures() {
            return (List<QGesture>) interceptor.Invoke("canceledGestures", "canceledGestures() const", typeof(List<QGesture>));
        }
        public void SetAccepted(bool accepted) {
            interceptor.Invoke("setAccepted$", "setAccepted(bool)", typeof(void), typeof(bool), accepted);
        }
        public bool IsAccepted() {
            return (bool) interceptor.Invoke("isAccepted", "isAccepted() const", typeof(bool));
        }
        public new void Accept() {
            interceptor.Invoke("accept", "accept()", typeof(void));
        }
        public new void Ignore() {
            interceptor.Invoke("ignore", "ignore()", typeof(void));
        }
        public void SetAccepted(QGesture arg1, bool arg2) {
            interceptor.Invoke("setAccepted#$", "setAccepted(QGesture*, bool)", typeof(void), typeof(QGesture), arg1, typeof(bool), arg2);
        }
        public void Accept(QGesture arg1) {
            interceptor.Invoke("accept#", "accept(QGesture*)", typeof(void), typeof(QGesture), arg1);
        }
        public void Ignore(QGesture arg1) {
            interceptor.Invoke("ignore#", "ignore(QGesture*)", typeof(void), typeof(QGesture), arg1);
        }
        public bool IsAccepted(QGesture arg1) {
            return (bool) interceptor.Invoke("isAccepted#", "isAccepted(QGesture*) const", typeof(bool), typeof(QGesture), arg1);
        }
        public void SetAccepted(Qt.GestureType arg1, bool arg2) {
            interceptor.Invoke("setAccepted$$", "setAccepted(Qt::GestureType, bool)", typeof(void), typeof(Qt.GestureType), arg1, typeof(bool), arg2);
        }
        public void Accept(Qt.GestureType arg1) {
            interceptor.Invoke("accept$", "accept(Qt::GestureType)", typeof(void), typeof(Qt.GestureType), arg1);
        }
        public void Ignore(Qt.GestureType arg1) {
            interceptor.Invoke("ignore$", "ignore(Qt::GestureType)", typeof(void), typeof(Qt.GestureType), arg1);
        }
        public bool IsAccepted(Qt.GestureType arg1) {
            return (bool) interceptor.Invoke("isAccepted$", "isAccepted(Qt::GestureType) const", typeof(bool), typeof(Qt.GestureType), arg1);
        }
        public void SetWidget(QWidget widget) {
            interceptor.Invoke("setWidget#", "setWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        public QWidget Widget() {
            return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
        }
        public QPointF MapToGraphicsScene(QPointF gesturePoint) {
            return (QPointF) interceptor.Invoke("mapToGraphicsScene#", "mapToGraphicsScene(const QPointF&) const", typeof(QPointF), typeof(QPointF), gesturePoint);
        }
        ~QGestureEvent() {
            interceptor.Invoke("~QGestureEvent", "~QGestureEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QGestureEvent", "~QGestureEvent()", typeof(void));
        }
    }
}
