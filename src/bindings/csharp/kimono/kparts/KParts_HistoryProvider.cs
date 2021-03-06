//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  Basic class to manage a history of "items". This class is only meant
    ///  for fast lookup, if an item is in the history or not.
    ///  May be subclassed to implement a persistent history for example.
    ///  For usage with khtml, just create your provider and call the
    ///  HistoryProvider constructor _before_ you do any khtml stuff. That way,
    ///  khtml, using the self()-method, will use your subclassed provider.
    ///  See <see cref="IHistoryProviderSignals"></see> for signals emitted by HistoryProvider
    /// </remarks>        <author> Carsten Pfeiffer <pfeiffer@kde.org>
    ///  </author>
    ///         <short>    Basic class to manage a history of "items".</short>
    [SmokeClass("KParts::HistoryProvider")]
    public class HistoryProvider : QObject {
        protected HistoryProvider(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(HistoryProvider), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static HistoryProvider() {
            staticInterceptor = new SmokeInvocation(typeof(HistoryProvider), null);
        }
        /// <remarks>
        /// </remarks>        <return> true if <code>item</code> is present in the history.
        ///      </return>
        ///         <short>   </short>
        [SmokeMethod("contains(const QString&) const")]
        public virtual bool Contains(string item) {
            return (bool) interceptor.Invoke("contains$", "contains(const QString&) const", typeof(bool), typeof(string), item);
        }
        /// <remarks>
        ///  Inserts <code>item</code> into the history.
        ///      </remarks>        <short>    Inserts <code>item</code> into the history.</short>
        [SmokeMethod("insert(const QString&)")]
        public virtual void Insert(string item) {
            interceptor.Invoke("insert$", "insert(const QString&)", typeof(void), typeof(string), item);
        }
        /// <remarks>
        ///  Removes <code>item</code> from the history.
        ///      </remarks>        <short>    Removes <code>item</code> from the history.</short>
        [SmokeMethod("remove(const QString&)")]
        public virtual void Remove(string item) {
            interceptor.Invoke("remove$", "remove(const QString&)", typeof(void), typeof(string), item);
        }
        /// <remarks>
        ///  Clears the history. The cleared() signal is emitted after clearing.
        ///      </remarks>        <short>    Clears the history.</short>
        [SmokeMethod("clear()")]
        public virtual void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        /// <remarks>
        ///  Creates a KHistoryProvider with an optional parent and name
        ///      </remarks>        <short>    Creates a KHistoryProvider with an optional parent and name      </short>
        public HistoryProvider(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("HistoryProvider#", "HistoryProvider(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public HistoryProvider() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("HistoryProvider", "HistoryProvider()", typeof(void));
        }
        public static KParts.HistoryProvider Self() {
            return (KParts.HistoryProvider) staticInterceptor.Invoke("self", "self()", typeof(KParts.HistoryProvider));
        }
        protected new IHistoryProviderSignals Emit {
            get { return (IHistoryProviderSignals) Q_EMIT; }
        }
    }

    public interface IHistoryProviderSignals : IQObjectSignals {
        /// <remarks>
        ///  Emitted after the history has been cleared.
        ///      </remarks>        <short>    Emitted after the history has been cleared.</short>
        [Q_SIGNAL("void cleared()")]
        void Cleared();
        /// <remarks>
        ///  This signal is never emitted from this class, it is only meant as an
        ///  interface for subclasses. Emit this signal to notify others that the
        ///  history has changed. Put those items that were added or removed from the
        ///  history into <code>items.</code>
        ///      </remarks>        <short>    This signal is never emitted from this class, it is only meant as an  interface for subclasses.</short>
        [Q_SIGNAL("void updated(QStringList)")]
        void Updated(List<string> items);
        /// <remarks>
        ///  Emitted after the item has been inserted
        ///      </remarks>        <short>    Emitted after the item has been inserted      </short>
        [Q_SIGNAL("void inserted(QString)")]
        void Inserted(string item);
    }
}
