//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \short A Cursor which is bound to a specific Document, and maintains its position.
    ///  \ingroup kte_group_smart_classes
    ///  A SmartCursor is an extension of the basic Cursor class. It maintains its
    ///  position in the document and provides a number of convenience methods,
    ///  including those for accessing and manipulating the content of the associated
    ///  Document.  As a result of this, SmartCursor%s may not be copied, as they need
    ///  to maintain a connection to the associated Document.
    ///  To receive notifications when the position of the cursor changes, or other
    ///  similar notifications, see either SmartCursorNotifier for QObject signal
    ///  notification via notifier(), or SmartCursorWatcher for inheritance
    ///  notification via setWatcher().
    ///  Create a new SmartCursor like this:
    ///  <pre>
    ///  // Retrieve the SmartInterface
    ///  KTextEditor.SmartInterface smart =
    ///      qobject_cast<KTextEditor.SmartInterface>( yourDocument );
    ///  if ( smart ) {
    ///      KTextEditor.SmartCursor cursor = smart.NewSmartCursor();
    ///  }
    ///  </pre>
    ///  When finished with a SmartCursor, simply delete it.
    ///  \sa Cursor, SmartCursorNotifier, SmartCursorWatcher, and SmartInterface.
    ///  \author Hamish Rodda \<rodda@kde.org\>
    ///  </remarks>        <short>    \short A Cursor which is bound to a specific Document, and maintains its position.</short>
    [SmokeClass("KTextEditor::SmartCursor")]
    public class SmartCursor : KTextEditor.Cursor, IDisposable {
        protected SmartCursor(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(SmartCursor), this);
        }
        /// <remarks>
        ///  Defines the ways in which the cursor can be advanced.
        ///  Important for languages where multiple characters are required to
        ///  form one letter.
        ///      </remarks>        <short>    Defines the ways in which the cursor can be advanced.</short>
        public enum AdvanceMode {
            ByCharacter = 0,
            ByCursorPosition = 1,
        }
        /// <remarks>
        ///  \}
        ///  \name Behavior
        ///  The following functions relate to the behavior of this SmartCursor.
        ///  \{
        ///      </remarks>        <short>    \} </short>
        public enum InsertBehavior {
            StayOnInsert = 0,
            MoveOnInsert = 1,
        }
        /// <remarks>
        ///  Returns that this cursor is a SmartCursor.
        ///      </remarks>        <short>    Returns that this cursor is a SmartCursor.</short>
        [SmokeMethod("isSmartCursor() const")]
        public override bool IsSmartCursor() {
            return (bool) interceptor.Invoke("isSmartCursor", "isSmartCursor() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns this cursor as a SmartCursor
        ///      </remarks>        <short>    Returns this cursor as a SmartCursor      </short>
        [SmokeMethod("toSmartCursor() const")]
        public override KTextEditor.SmartCursor ToSmartCursor() {
            return (KTextEditor.SmartCursor) interceptor.Invoke("toSmartCursor", "toSmartCursor() const", typeof(KTextEditor.SmartCursor));
        }
        /// <remarks>
        ///  Returns the range that this cursor belongs to, if any.
        ///  \sa Cursor.Range()
        ///      </remarks>        <short>    Returns the range that this cursor belongs to, if any.</short>
        public KTextEditor.SmartRange SmartRange() {
            return (KTextEditor.SmartRange) interceptor.Invoke("smartRange", "smartRange() const", typeof(KTextEditor.SmartRange));
        }
        /// <remarks>
        ///  Returns the document to which this cursor is attached.
        ///      </remarks>        <short>    Returns the document to which this cursor is attached.</short>
        public KTextEditor.Document Document() {
            return (KTextEditor.Document) interceptor.Invoke("document", "document() const", typeof(KTextEditor.Document));
        }
        /// <remarks>
        ///  Determine if this cursor is located at the end of the current line.
        ///  \return \e true if the cursor is situated at the end of the line, otherwise \e false.
        ///      </remarks>        <short>    Determine if this cursor is located at the end of the current line.</short>
        [SmokeMethod("atEndOfLine() const")]
        public virtual bool AtEndOfLine() {
            return (bool) interceptor.Invoke("atEndOfLine", "atEndOfLine() const", typeof(bool));
        }
        /// <remarks>
        ///  Determine if this cursor is located at the end of the document.
        ///  \return \e true if the cursor is situated at the end of the document, otherwise \e false.
        ///      </remarks>        <short>    Determine if this cursor is located at the end of the document.</short>
        [SmokeMethod("atEndOfDocument() const")]
        public virtual bool AtEndOfDocument() {
            return (bool) interceptor.Invoke("atEndOfDocument", "atEndOfDocument() const", typeof(bool));
        }
        /// <remarks>
        ///  \overload bool Cursor.IsValid()
        ///  \sa Document.CursorInText()
        ///      </remarks>        <short>    \overload bool Cursor.IsValid()  \sa Document.CursorInText()      </short>
        [SmokeMethod("isValid() const")]
        public override bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns the character in the document immediately after this position,
        ///  ie. from this position to this position plus Cursor(0,1).
        ///      </remarks>        <short>    Returns the character in the document immediately after this position,  ie.</short>
        public QChar Character() {
            return (QChar) interceptor.Invoke("character", "character() const", typeof(QChar));
        }
        /// <remarks>
        ///  Insert <pre>text</pre> into the associated Document.
        ///  \param text text to insert
        ///  \param block insert this text as a visual block of text rather than a linear sequence
        ///  \return \e true on success, otherwise \e false
        ///      </remarks>        <short>    Insert \p text into the associated Document.</short>
        [SmokeMethod("insertText(const QStringList&, bool)")]
        public virtual bool InsertText(List<string> text, bool block) {
            return (bool) interceptor.Invoke("insertText?$", "insertText(const QStringList&, bool)", typeof(bool), typeof(List<string>), text, typeof(bool), block);
        }
        [SmokeMethod("insertText(const QStringList&)")]
        public virtual bool InsertText(List<string> text) {
            return (bool) interceptor.Invoke("insertText?", "insertText(const QStringList&)", typeof(bool), typeof(List<string>), text);
        }
        /// <remarks>
        ///  Move cursor by specified \a distance along the document buffer.
        ///  E.g.:
        ///  <pre>
        ///  cursor.advance(1);
        ///  </pre>
        ///  will move the cursor forward by one character, or, if the cursor is already
        ///  on the end of the line, will move it to the start of the next line.
        ///  <b>Note:<> Negative numbers should be accepted, and move backwards.
        ///  <b>Note:<> Not all \a mode%s are required to be supported.
        ///  \param distance distance to advance (or go back if \a distance is negative)
        ///  \param mode whether to move by character, or by number of valid cursor positions
        ///  \return true if the position could be reached within the document, otherwise false
        ///          (the cursor should not move if \a distance is beyond the end of the document).
        ///      </remarks>        <short>    Move cursor by specified \a distance along the document buffer.</short>
        [SmokeMethod("advance(int, KTextEditor::SmartCursor::AdvanceMode)")]
        public virtual bool Advance(int distance, KTextEditor.SmartCursor.AdvanceMode mode) {
            return (bool) interceptor.Invoke("advance$$", "advance(int, KTextEditor::SmartCursor::AdvanceMode)", typeof(bool), typeof(int), distance, typeof(KTextEditor.SmartCursor.AdvanceMode), mode);
        }
        [SmokeMethod("advance(int)")]
        public virtual bool Advance(int distance) {
            return (bool) interceptor.Invoke("advance$", "advance(int)", typeof(bool), typeof(int), distance);
        }
        /// <remarks>
        ///  Returns how this cursor behaves when text is inserted at the cursor.
        ///  Defaults to moving on insert.
        ///      </remarks>        <short>    Returns how this cursor behaves when text is inserted at the cursor.</short>
        public KTextEditor.SmartCursor.InsertBehavior insertBehavior() {
            return (KTextEditor.SmartCursor.InsertBehavior) interceptor.Invoke("insertBehavior", "insertBehavior() const", typeof(KTextEditor.SmartCursor.InsertBehavior));
        }
        /// <remarks>
        ///  Change the behavior of the cursor when text is inserted at the cursor.
        ///  If <pre>moveOnInsert</pre> is true, the cursor will end up at the end of the insert.
        ///      </remarks>        <short>    Change the behavior of the cursor when text is inserted at the cursor.</short>
        public void SetInsertBehavior(KTextEditor.SmartCursor.InsertBehavior insertBehavior) {
            interceptor.Invoke("setInsertBehavior$", "setInsertBehavior(KTextEditor::SmartCursor::InsertBehavior)", typeof(void), typeof(KTextEditor.SmartCursor.InsertBehavior), insertBehavior);
        }
        /// <remarks>
        ///  Determine if a notifier already exists for this smart cursor.
        ///  \return \e true if a notifier already exists, otherwise \e false
        ///      </remarks>        <short>    Determine if a notifier already exists for this smart cursor.</short>
        [SmokeMethod("hasNotifier() const")]
        public virtual bool HasNotifier() {
            return (bool) interceptor.Invoke("hasNotifier", "hasNotifier() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns the current SmartCursorNotifier.  If one does not already exist,
        ///  it will be created.
        ///  Connect to the notifier to receive signals indicating change of state of this cursor.
        ///  The notifier is created at the time it is first requested.  If you have finished with
        ///  notifications for a reasonable period of time you can save memory, and potentially
        ///  editor logic processing time, by calling deleteNotifier().
        ///  \return a pointer to the current SmartCursorNotifier for this SmartCursor.
        ///          If one does not already exist, it will be created.
        ///      </remarks>        <short>    Returns the current SmartCursorNotifier.</short>
        [SmokeMethod("notifier()")]
        public virtual KTextEditor.SmartCursorNotifier Notifier() {
            return (KTextEditor.SmartCursorNotifier) interceptor.Invoke("notifier", "notifier()", typeof(KTextEditor.SmartCursorNotifier));
        }
        /// <remarks>
        ///  Deletes the current SmartCursorNotifier.
        ///  When finished with a notifier, call this method to save memory, and potentially
        ///  editor logic processing time, by having the SmartCursorNotifier deleted.
        ///      </remarks>        <short>    Deletes the current SmartCursorNotifier.</short>
        [SmokeMethod("deleteNotifier()")]
        public virtual void DeleteNotifier() {
            interceptor.Invoke("deleteNotifier", "deleteNotifier()", typeof(void));
        }
        /// <remarks>
        ///  Returns a pointer to the current SmartCursorWatcher, if one has been set.
        ///  \return the current SmartCursorWatcher pointer if one exists, otherwise null.
        ///      </remarks>        <short>    Returns a pointer to the current SmartCursorWatcher, if one has been set.</short>
        [SmokeMethod("watcher() const")]
        public virtual KTextEditor.SmartCursorWatcher Watcher() {
            return (KTextEditor.SmartCursorWatcher) interceptor.Invoke("watcher", "watcher() const", typeof(KTextEditor.SmartCursorWatcher));
        }
        /// <remarks>
        ///  Provide a SmartCursorWatcher to receive calls indicating change of state of this cursor.
        ///  To finish receiving notifications, call this function with <pre>watcher</pre> set to null.
        ///  \param watcher the class which will receive notifications about changes to this cursor.
        ///      </remarks>        <short>    Provide a SmartCursorWatcher to receive calls indicating change of state of this cursor.</short>
        [SmokeMethod("setWatcher(KTextEditor::SmartCursorWatcher*)")]
        public virtual void SetWatcher(KTextEditor.SmartCursorWatcher watcher) {
            interceptor.Invoke("setWatcher#", "setWatcher(KTextEditor::SmartCursorWatcher*)", typeof(void), typeof(KTextEditor.SmartCursorWatcher), watcher);
        }
        [SmokeMethod("setWatcher()")]
        public virtual void SetWatcher() {
            interceptor.Invoke("setWatcher", "setWatcher()", typeof(void));
        }
        /// <remarks>
        ///  \internal
        ///  Constructor for subclasses to utilise.  Protected to prevent direct
        ///  instantiation.
        ///  <b>Note:<> 3rd party developers: you do not (and should not) need to subclass
        ///        the Smart classes; instead, use the SmartInterface to create instances.
        ///  \param position the cursor position to assign
        ///  \param doc the Document this cursor is associated with
        ///  \param insertBehavior the behavior of this cursor when on the position of an insert.
        ///      </remarks>        <short>    \internal </short>
        public SmartCursor(KTextEditor.Cursor position, KTextEditor.Document doc, KTextEditor.SmartCursor.InsertBehavior insertBehavior) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("SmartCursor##$", "SmartCursor(const KTextEditor::Cursor&, KTextEditor::Document*, KTextEditor::SmartCursor::InsertBehavior)", typeof(void), typeof(KTextEditor.Cursor), position, typeof(KTextEditor.Document), doc, typeof(KTextEditor.SmartCursor.InsertBehavior), insertBehavior);
        }
        ~SmartCursor() {
            interceptor.Invoke("~SmartCursor", "~SmartCursor()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~SmartCursor", "~SmartCursor()", typeof(void));
        }
    }
}
