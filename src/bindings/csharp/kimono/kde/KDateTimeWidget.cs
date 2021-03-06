//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  This widget can be used to display or allow user selection of date and time.
    ///  \image html kdatetimewidget.png "KDE Date Time Widget"
    ///  See <see cref="IKDateTimeWidgetSignals"></see> for signals emitted by KDateTimeWidget
    /// </remarks>        <author> Hans Petter Bieker <bieker@kde.org>
    ///  </author>
    ///         <short> A combination of a date and a time selection widget. </short>
    ///         <see> KDateWidget</see>
    [SmokeClass("KDateTimeWidget")]
    public class KDateTimeWidget : QWidget, IDisposable {
        protected KDateTimeWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KDateTimeWidget), this);
        }
        [Q_PROPERTY("QDateTime", "dateTime")]
        public QDateTime DateTime {
            get { return (QDateTime) interceptor.Invoke("dateTime", "dateTime()", typeof(QDateTime)); }
            set { interceptor.Invoke("setDateTime#", "setDateTime(QDateTime)", typeof(void), typeof(QDateTime), value); }
        }
        /// <remarks>
        ///  Constructs a date and time selection widget.
        ///    </remarks>        <short>    Constructs a date and time selection widget.</short>
        public KDateTimeWidget(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDateTimeWidget#", "KDateTimeWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KDateTimeWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDateTimeWidget", "KDateTimeWidget()", typeof(void));
        }
        /// <remarks>
        ///  Constructs a date and time selection widget with the initial date and
        ///  time set to <code>datetime.</code>
        ///    </remarks>        <short>    Constructs a date and time selection widget with the initial date and  time set to <code>datetime.</code></short>
        public KDateTimeWidget(QDateTime datetime, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDateTimeWidget##", "KDateTimeWidget(const QDateTime&, QWidget*)", typeof(void), typeof(QDateTime), datetime, typeof(QWidget), parent);
        }
        public KDateTimeWidget(QDateTime datetime) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDateTimeWidget#", "KDateTimeWidget(const QDateTime&)", typeof(void), typeof(QDateTime), datetime);
        }
        /// <remarks>
        ///  Changes the selected date and time to <code>datetime.</code>
        ///    </remarks>        <short>    Changes the selected date and time to <code>datetime.</code></short>
        [Q_SLOT("void setDateTime(QDateTime)")]
        public void SetDateTime(QDateTime datetime) {
            interceptor.Invoke("setDateTime#", "setDateTime(const QDateTime&)", typeof(void), typeof(QDateTime), datetime);
        }
        ~KDateTimeWidget() {
            interceptor.Invoke("~KDateTimeWidget", "~KDateTimeWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KDateTimeWidget", "~KDateTimeWidget()", typeof(void));
        }
        protected new IKDateTimeWidgetSignals Emit {
            get { return (IKDateTimeWidgetSignals) Q_EMIT; }
        }
    }

    public interface IKDateTimeWidgetSignals : IQWidgetSignals {
        /// <remarks>
        ///  Emitted whenever the date or time of the widget
        ///  is changed, either with setDateTime() or via user selection.
        ///    </remarks>        <short>    Emitted whenever the date or time of the widget  is changed, either with setDateTime() or via user selection.</short>
        [Q_SIGNAL("void valueChanged(QDateTime)")]
        void ValueChanged(QDateTime datetime);
    }
}
