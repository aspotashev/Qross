//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  The KShortcut class is used to represent a keyboard shortcut to an action.
    ///  A shortcut is normally a single key with modifiers, such as Ctrl+V.
    ///  A KShortcut object may also contain an alternate key sequence which will also
    ///  activate the action it's associated with, as long as no other actions have
    ///  defined that key as their primary key. Ex: Ctrl+V;Shift+Insert.
    ///  This can be used to add additional accelerators to a KAction. For example,
    ///  the below code binds the escape key to the close action.
    ///  <pre>
    ///   KAction closeAction = KStandardAction.Close(this, SLOT("close()"), actionCollection());
    ///   KShortcut closeShortcut = closeAction.Shortcut();
    ///   closeShortcut.setAlternate(Qt.Key_Escape);
    ///   closeAction.SetShortcut(closeShortcut);
    ///  </pre>
    /// </remarks>        <short> Represents a keyboard shortcut.</short>
    [SmokeClass("KShortcut")]
    public class KShortcut : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KShortcut(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KShortcut), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KShortcut() {
            staticInterceptor = new SmokeInvocation(typeof(KShortcut), null);
        }
        /// <remarks>
        ///  An enum about the behavior of operations that treat a KShortcut like a list of QKeySequences.
        ///      </remarks>        <short>    An enum about the behavior of operations that treat a KShortcut like a list of QKeySequences.</short>
        public enum EmptyHandling {
            KeepEmpty = 0,
            RemoveEmpty = 1,
        }
        //  operator QList<QKeySequence>(); >>>> NOT CONVERTED
        //  operator QVariant(); >>>> NOT CONVERTED
        /// <remarks>
        ///  Creates a new empty shortcut.
        /// </remarks>        <short>    Creates a new empty shortcut.</short>
        ///         <see> isEmpty</see>
        ///         <see> clear</see>
        public KShortcut() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut", "KShortcut()", typeof(void));
        }
        /// <remarks>
        ///  Creates a new shortcut that contains the given Qt key
        ///  sequence as primary shortcut.
        /// <param> name="primary" Qt key sequence to add
        ///      </param></remarks>        <short>    Creates a new shortcut that contains the given Qt key  sequence as primary shortcut.</short>
        public KShortcut(QKeySequence primary) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut#", "KShortcut(const QKeySequence&)", typeof(void), typeof(QKeySequence), primary);
        }
        /// <remarks>
        ///  Creates a new shortcut with the given Qt key sequences
        ///  as primary and secondary shortcuts.
        /// <param> name="primary" Qt keycode of primary shortcut
        /// </param><param> name="alternate" Qt keycode of alternate shortcut
        /// </param></remarks>        <short>    Creates a new shortcut with the given Qt key sequences  as primary and secondary shortcuts.</short>
        ///         <see> Qt.Key</see>
        public KShortcut(QKeySequence primary, QKeySequence alternate) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut##", "KShortcut(const QKeySequence&, const QKeySequence&)", typeof(void), typeof(QKeySequence), primary, typeof(QKeySequence), alternate);
        }
        /// <remarks>
        ///  Creates a new shortcut with the given Qt key codes
        ///  as primary and secondary shortcuts.
        ///  You can only assign single-key shortcuts this way.
        /// <param> name="keyQtPri" Qt keycode of primary shortcut
        /// </param><param> name="keyQtAlt" Qt keycode of alternate shortcut
        /// </param></remarks>        <short>    Creates a new shortcut with the given Qt key codes  as primary and secondary shortcuts.</short>
        ///         <see> Qt.Key</see>
        public KShortcut(int keyQtPri, int keyQtAlt) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut$$", "KShortcut(int, int)", typeof(void), typeof(int), keyQtPri, typeof(int), keyQtAlt);
        }
        public KShortcut(int keyQtPri) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut$", "KShortcut(int)", typeof(void), typeof(int), keyQtPri);
        }
        /// <remarks>
        ///  Copy constructor.
        ///      </remarks>        <short>    Copy constructor.</short>
        public KShortcut(KShortcut other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut#", "KShortcut(const KShortcut&)", typeof(void), typeof(KShortcut), other);
        }
        /// <remarks>
        ///  Creates a new shortcut that contains the key sequences described
        ///  in <code>description.</code> The format of description is the same as
        ///  used in QKeySequence.FromString(string).
        ///  Up to two key sequences separated by a semicolon followed by a
        ///  space "; " may be given.
        /// <param> name="description" the description of key sequence(s)
        /// </param></remarks>        <short>    Creates a new shortcut that contains the key sequences described  in <code>description.</code></short>
        ///         <see> QKeySequence.FromString(const</see>
        ///         <see> SequenceFormat)</see>
        public KShortcut(string description) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut$", "KShortcut(const QString&)", typeof(void), typeof(string), description);
        }
        /// <remarks>
        ///  Creates a new shortcut with the given Qt key sequences.
        ///  The first sequence in the list is considered to be the primary
        ///  sequence, the second one the alternate.
        /// <param> name="seqs" List of key sequeces.
        ///      </param></remarks>        <short>    Creates a new shortcut with the given Qt key sequences.</short>
        public KShortcut(List<QKeySequence> seqs) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KShortcut?", "KShortcut(const QList<QKeySequence>&)", typeof(void), typeof(List<QKeySequence>), seqs);
        }
        /// <remarks>
        ///  Returns the primary key sequence of this shortcut.
        /// </remarks>        <return> primary key sequence
        ///      </return>
        ///         <short>    Returns the primary key sequence of this shortcut.</short>
        public QKeySequence Primary() {
            return (QKeySequence) interceptor.Invoke("primary", "primary() const", typeof(QKeySequence));
        }
        /// <remarks>
        ///  Returns the alternate key sequence of this shortcut.
        /// </remarks>        <return> alternate key sequence
        ///      </return>
        ///         <short>    Returns the alternate key sequence of this shortcut.</short>
        public QKeySequence Alternate() {
            return (QKeySequence) interceptor.Invoke("alternate", "alternate() const", typeof(QKeySequence));
        }
        /// <remarks>
        ///  Returns whether this shortcut contains any nonempty key sequences.
        /// </remarks>        <return> whether this shortcut is empty
        ///      </return>
        ///         <short>    Returns whether this shortcut contains any nonempty key sequences.</short>
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns whether at least one of the key sequences is equal to <code>needle.</code>
        /// </remarks>        <return> whether this shortcut contains <code>needle</code>
        ///      </return>
        ///         <short>    Returns whether at least one of the key sequences is equal to <code>needle.</code></short>
        public bool Contains(QKeySequence needle) {
            return (bool) interceptor.Invoke("contains#", "contains(const QKeySequence&) const", typeof(bool), typeof(QKeySequence), needle);
        }
        /// <remarks>
        ///  Returns a description of the shortcut as a semicolon-separated
        ///  list of key sequences, as returned by QKeySequence.ToString().
        /// </remarks>        <return> the string represenation of this shortcut
        /// </return>
        ///         <short>    Returns a description of the shortcut as a semicolon-separated  list of key sequences, as returned by QKeySequence.ToString().</short>
        ///         <see> QKeySequence.ToString</see>
        ///         <see> KShortcut(const</see>
        ///         <see> &description)</see>
        public new string ToString() {
            return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
        }
        public override bool Equals(object o) {
            if (!(o is KShortcut)) { return false; }
            return this == (KShortcut) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        /// <remarks>
        ///  Returns shortcut as QList\<QKeySequence\>, and is equivalent to toList(RemoveEmpty).
        ///  Be aware that empty shortcuts will not be included in the list;
        ///  due to this, conversion operations like
        ///  KShortcut b = (QList\<QKeySequence\>)KShortcut a
        ///  will not always result in b == a.
        /// </remarks>        <return> the shortcut converted to a QList\<QKeySequence\>
        ///      </return>
        ///         <short>    Returns shortcut as QList\<QKeySequence\>, and is equivalent to toList(RemoveEmpty).</short>
        /// <remarks>
        ///  The same as operator QList\<QKeySequence\>()
        ///  If <code>handleEmpty</code> equals RemoveEmpty, empty key sequences will be left out of the result.
        ///  Otherwise, empy key sequences will be included; you can be sure that
        ///  shortcut.alternate() == shortcut.toList(KeepEmpty).at(1).
        /// </remarks>        <return> the shortcut converted to a QList\<QKeySequence\>
        ///      </return>
        ///         <short>    The same as operator QList\<QKeySequence\>()  If <code>handleEmpty</code> equals RemoveEmpty, empty key sequences will be left out of the result.</short>
        public List<QKeySequence> ToList(KShortcut.EmptyHandling handleEmpty) {
            return (List<QKeySequence>) interceptor.Invoke("toList$", "toList(KShortcut::EmptyHandling) const", typeof(List<QKeySequence>), typeof(KShortcut.EmptyHandling), handleEmpty);
        }
        public List<QKeySequence> ToList() {
            return (List<QKeySequence>) interceptor.Invoke("toList", "toList() const", typeof(List<QKeySequence>));
        }
        /// <remarks>
        ///  Returns shortcut as QVariant.
        ///      </remarks>        <short>    Returns shortcut as QVariant.</short>
        /// <remarks>
        ///  Set the primary key sequence of this shortcut to the given key sequence.
        /// <param> name="keySeq" set primary key sequence to this
        ///      </param></remarks>        <short>    Set the primary key sequence of this shortcut to the given key sequence.</short>
        public void SetPrimary(QKeySequence keySeq) {
            interceptor.Invoke("setPrimary#", "setPrimary(const QKeySequence&)", typeof(void), typeof(QKeySequence), keySeq);
        }
        /// <remarks>
        ///  Set the alternate key sequence of this shortcut to the given key sequence.
        /// <param> name="keySeq" set alternate key sequence to this
        ///      </param></remarks>        <short>    Set the alternate key sequence of this shortcut to the given key sequence.</short>
        public void SetAlternate(QKeySequence keySeq) {
            interceptor.Invoke("setAlternate#", "setAlternate(const QKeySequence&)", typeof(void), typeof(QKeySequence), keySeq);
        }
        /// <remarks>
        ///  Remove <code>keySeq</code> from this shortcut.
        ///  If <code>handleEmpty</code> equals RemoveEmpty, following key sequences will move up to take the place of
        ///  <code>keySeq.</code> Otherwise, key sequences equal to <code>keySeq</code> will be set to empty.
        /// <param> name="keySeq" remove this key sequence from the shortcut
        ///      </param></remarks>        <short>    Remove <code>keySeq</code> from this shortcut.</short>
        public void Remove(QKeySequence keySeq, KShortcut.EmptyHandling handleEmpty) {
            interceptor.Invoke("remove#$", "remove(const QKeySequence&, KShortcut::EmptyHandling)", typeof(void), typeof(QKeySequence), keySeq, typeof(KShortcut.EmptyHandling), handleEmpty);
        }
        public void Remove(QKeySequence keySeq) {
            interceptor.Invoke("remove#", "remove(const QKeySequence&)", typeof(void), typeof(QKeySequence), keySeq);
        }
        ~KShortcut() {
            interceptor.Invoke("~KShortcut", "~KShortcut()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KShortcut", "~KShortcut()", typeof(void));
        }
        public static bool operator==(KShortcut lhs, KShortcut other) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const KShortcut&) const", typeof(bool), typeof(KShortcut), lhs, typeof(KShortcut), other);
        }
        public static bool operator!=(KShortcut lhs, KShortcut other) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const KShortcut&) const", typeof(bool), typeof(KShortcut), lhs, typeof(KShortcut), other);
        }
    }
}
