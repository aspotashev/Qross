//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  The transfer job pumps data into and/or out of a Slave.
    ///  Data is sent to the slave on request of the slave ( dataReq).
    ///  If data coming from the slave can not be handled, the
    ///  reading of data from the slave should be suspended.
    ///       See <see cref="ITransferJobSignals"></see> for signals emitted by TransferJob
    /// </remarks>        <short>    The transfer job pumps data into and/or out of a Slave.</short>
    [SmokeClass("KIO::TransferJob")]
    public class TransferJob : KIO.SimpleJob, IDisposable {
        protected TransferJob(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(TransferJob), this);
        }
        // KIO::TransferJob* TransferJob(KIO::TransferJobPrivate& arg1); >>>> NOT CONVERTED
        /// <remarks>
        ///  Sets the modification time of the file to be created (by KIO.Put)
        ///  Note that some kioslaves might ignore this.
        ///          </remarks>        <short>    Sets the modification time of the file to be created (by KIO.Put)  Note that some kioslaves might ignore this.</short>
        public void SetModificationTime(QDateTime mtime) {
            interceptor.Invoke("setModificationTime#", "setModificationTime(const QDateTime&)", typeof(void), typeof(QDateTime), mtime);
        }
        /// <remarks>
        ///  Checks whether we got an error page. This currently only happens
        ///  with HTTP urls. Call this from your slot connected to result().
        /// </remarks>        <return> true if we got an (HTML) error page from the server
        ///  instead of what we asked for.
        ///          </return>
        ///         <short>    Checks whether we got an error page.</short>
        public bool IsErrorPage() {
            return (bool) interceptor.Invoke("isErrorPage", "isErrorPage() const", typeof(bool));
        }
        /// <remarks>
        ///  Enable the async data mode.
        ///  When async data is enabled, data should be provided to the job by
        ///  calling sendAsyncData() instead of returning data in the
        ///  dataReq() signal.
        ///          </remarks>        <short>    Enable the async data mode.</short>
        public void SetAsyncDataEnabled(bool enabled) {
            interceptor.Invoke("setAsyncDataEnabled$", "setAsyncDataEnabled(bool)", typeof(void), typeof(bool), enabled);
        }
        /// <remarks>
        ///  Provide data to the job when async data is enabled.
        ///  Should be called exactly once after receiving a dataReq signal
        ///  Sending an empty block indicates end of data.
        ///          </remarks>        <short>    Provide data to the job when async data is enabled.</short>
        public void SendAsyncData(QByteArray data) {
            interceptor.Invoke("sendAsyncData#", "sendAsyncData(const QByteArray&)", typeof(void), typeof(QByteArray), data);
        }
        /// <remarks>
        ///  When enabled, the job reports the amount of data that has been sent,
        ///  instead of the amount of data that that has been received.
        /// </remarks>        <short>    When enabled, the job reports the amount of data that has been sent,  instead of the amount of data that that has been received.</short>
        ///         <see> slotProcessedSize</see>
        ///         <see> slotSpeed</see>
        public void SetReportDataSent(bool enabled) {
            interceptor.Invoke("setReportDataSent$", "setReportDataSent(bool)", typeof(void), typeof(bool), enabled);
        }
        /// <remarks>
        ///   Returns whether the job reports the amount of data that has been
        ///   sent (true), or whether the job reports the amount of data that
        ///  has been received (false)
        ///          </remarks>        <short>     Returns whether the job reports the amount of data that has been   sent (true), or whether the job reports the amount of data that  has been received (false)          </short>
        public bool ReportDataSent() {
            return (bool) interceptor.Invoke("reportDataSent", "reportDataSent() const", typeof(bool));
        }
        /// <remarks>
        ///  Call this in the slot connected to result,
        ///  and only after making sure no error happened.
        /// </remarks>        <return> the mimetype of the URL
        ///          </return>
        ///         <short>    Call this in the slot connected to result,  and only after making sure no error happened.</short>
        public string Mimetype() {
            return (string) interceptor.Invoke("mimetype", "mimetype() const", typeof(string));
        }
        /// <remarks>
        ///  Called when m_subJob finishes.
        /// <param> name="job" the job that finished
        ///          </param></remarks>        <short>    Called when m_subJob finishes.</short>
        [SmokeMethod("slotResult(KJob*)")]
        protected override void SlotResult(KJob job) {
            interceptor.Invoke("slotResult#", "slotResult(KJob*)", typeof(void), typeof(KJob), job);
        }
        /// <remarks>
        ///  Reimplemented for internal reasons
        ///          </remarks>        <short>    Reimplemented for internal reasons          </short>
        [SmokeMethod("doResume()")]
        protected override bool DoResume() {
            return (bool) interceptor.Invoke("doResume", "doResume()", typeof(bool));
        }
        [Q_SLOT("void slotRedirection(KUrl)")]
        [SmokeMethod("slotRedirection(const KUrl&)")]
        protected virtual void SlotRedirection(KUrl url) {
            interceptor.Invoke("slotRedirection#", "slotRedirection(const KUrl&)", typeof(void), typeof(KUrl), url);
        }
        [Q_SLOT("void slotFinished()")]
        [SmokeMethod("slotFinished()")]
        protected override void SlotFinished() {
            interceptor.Invoke("slotFinished", "slotFinished()", typeof(void));
        }
        [Q_SLOT("void slotData(QByteArray)")]
        [SmokeMethod("slotData(const QByteArray&)")]
        protected virtual void SlotData(QByteArray data) {
            interceptor.Invoke("slotData#", "slotData(const QByteArray&)", typeof(void), typeof(QByteArray), data);
        }
        [Q_SLOT("void slotDataReq()")]
        [SmokeMethod("slotDataReq()")]
        protected virtual void SlotDataReq() {
            interceptor.Invoke("slotDataReq", "slotDataReq()", typeof(void));
        }
        [Q_SLOT("void slotMimetype(QString)")]
        [SmokeMethod("slotMimetype(const QString&)")]
        protected virtual void SlotMimetype(string mimetype) {
            interceptor.Invoke("slotMimetype$", "slotMimetype(const QString&)", typeof(void), typeof(string), mimetype);
        }
        [Q_SLOT("void slotMetaData(KIO::MetaData)")]
        [SmokeMethod("slotMetaData(const KIO::MetaData&)")]
        protected override void SlotMetaData(KIO.MetaData _metaData) {
            interceptor.Invoke("slotMetaData#", "slotMetaData(const KIO::MetaData&)", typeof(void), typeof(KIO.MetaData), _metaData);
        }
        ~TransferJob() {
            interceptor.Invoke("~TransferJob", "~TransferJob()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~TransferJob", "~TransferJob()", typeof(void));
        }
        protected new ITransferJobSignals Emit {
            get { return (ITransferJobSignals) Q_EMIT; }
        }
    }

    public interface ITransferJobSignals : KIO.ISimpleJobSignals {
        /// <remarks>
        ///  Data from the slave has arrived.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="data" data received from the slave.
        /// </param> End of data (EOD) has been reached if data.size() == 0, however, you
        ///  should not be certain of data.size() == 0 ever happening (e.g. in case
        ///  of an error), so you should rely on result() instead.
        ///          </remarks>        <short>    Data from the slave has arrived.</short>
        [Q_SIGNAL("void data(KIO::Job*, QByteArray)")]
        void Data(KIO.Job job, QByteArray data);
        /// <remarks>
        ///  Request for data.
        ///  Please note, that you shouldn't put too large chunks
        ///  of data in it as this requires copies within the frame
        ///  work, so you should rather split the data you want
        ///  to pass here in reasonable chunks (about 1MB maximum)
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="data" buffer to fill with data to send to the
        ///  slave. An empty buffer indicates end of data. (EOD)
        ///          </param></remarks>        <short>    Request for data.</short>
        [Q_SIGNAL("void dataReq(KIO::Job*, QByteArray)")]
        void DataReq(KIO.Job job, QByteArray data);
        /// <remarks>
        ///  Signals a redirection.
        ///  Use to update the URL shown to the user.
        ///  The redirection itself is handled internally.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="url" the new URL
        ///          </param></remarks>        <short>    Signals a redirection.</short>
        [Q_SIGNAL("void redirection(KIO::Job*, KUrl)")]
        void Redirection(KIO.Job job, KUrl url);
        /// <remarks>
        ///  Signals a permanent redirection.
        ///  The redirection itself is handled internally.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="fromUrl" the original URL
        /// </param><param> name="toUrl" the new URL
        ///          </param></remarks>        <short>    Signals a permanent redirection.</short>
        [Q_SIGNAL("void permanentRedirection(KIO::Job*, KUrl, KUrl)")]
        void PermanentRedirection(KIO.Job job, KUrl fromUrl, KUrl toUrl);
        /// <remarks>
        ///  Mimetype determined.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="type" the mime type
        ///          </param></remarks>        <short>    Mimetype determined.</short>
        [Q_SIGNAL("void mimetype(KIO::Job*, QString)")]
        void Mimetype(KIO.Job job, string type);
        /// <remarks>
        ///  Emitted if the "put" job found an existing partial file
        ///  (in which case offset is the size of that file)
        ///  and emitted by the "get" job if it supports resuming to
        ///  the given offset - in this case <code>offset</code> is unused)
        ///          </remarks>        <short>   </short>
        [Q_SIGNAL("void canResume(KIO::Job*, KIO::filesize_t)")]
        void CanResume(KIO.Job job, long offset);
    }
}
