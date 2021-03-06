//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \short A class which provides notifications of state changes to a SmartRange via QObject signals.
    ///  \ingroup kte_group_smart_classes
    ///  This class provides notifications of changes to the position or contents of
    ///  a SmartRange via QObject signals.
    ///  If you prefer to receive notifications via inheritance, see SmartRangeWatcher.
    ///  \sa SmartRange, SmartRangeWatcher
    ///  \author Hamish Rodda \<rodda@kde.org\>
    ///   See <see cref="ISmartRangeNotifierSignals"></see> for signals emitted by SmartRangeNotifier
    /// </remarks>        <short>    \short A class which provides notifications of state changes to a SmartRange via QObject signals.</short>
    [SmokeClass("KTextEditor::SmartRangeNotifier")]
    public class SmartRangeNotifier : QObject, IDisposable {
        protected SmartRangeNotifier(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(SmartRangeNotifier), this);
        }
        /// <remarks>
        ///  Default constructor.
        ///      </remarks>        <short>    Default constructor.</short>
        public SmartRangeNotifier() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("SmartRangeNotifier", "SmartRangeNotifier()", typeof(void));
        }
        /// <remarks>
        ///  Returns whether this notifier will notify of changes that happen
        ///  directly to the range, e.g. by calls to SmartCursor.SetRange(), or by
        ///  direct assignment to either of the start() or end() cursors, rather
        ///  than just when surrounding text changes.
        ///      </remarks>        <short>    Returns whether this notifier will notify of changes that happen  directly to the range, e.</short>
        public bool WantsDirectChanges() {
            return (bool) interceptor.Invoke("wantsDirectChanges", "wantsDirectChanges() const", typeof(bool));
        }
        /// <remarks>
        ///  Set whether this notifier should notify of changes that happen
        ///  directly to the range, e.g. by calls to SmartCursor.SetRange(), or by
        ///  direct assignment to either of the start() or end() cursors, rather
        ///  than just when surrounding text changes.
        ///  \param wantsDirectChanges whether this watcher should provide notifications for direct changes.
        ///      </remarks>        <short>    Set whether this notifier should notify of changes that happen  directly to the range, e.</short>
        public void SetWantsDirectChanges(bool wantsDirectChanges) {
            interceptor.Invoke("setWantsDirectChanges$", "setWantsDirectChanges(bool)", typeof(void), typeof(bool), wantsDirectChanges);
        }
        ~SmartRangeNotifier() {
            interceptor.Invoke("~SmartRangeNotifier", "~SmartRangeNotifier()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~SmartRangeNotifier", "~SmartRangeNotifier()", typeof(void));
        }
        protected new ISmartRangeNotifierSignals Emit {
            get { return (ISmartRangeNotifierSignals) Q_EMIT; }
        }
    }

    public interface ISmartRangeNotifierSignals : IQObjectSignals {
        /// <remarks>
        ///  The range's position changed.
        ///  \param range pointer to the range which generated the notification.
        ///      </remarks>        <short>    The range's position changed.</short>
        [Q_SIGNAL("void rangePositionChanged(KTextEditor::SmartRange*)")]
        void RangePositionChanged(KTextEditor.SmartRange range);
        /// <remarks>
        ///  The contents of the range changed.
        ///  \param range pointer to the range which generated the notification.
        ///      </remarks>        <short>    The contents of the range changed.</short>
        [Q_SIGNAL("void rangeContentsChanged(KTextEditor::SmartRange*)")]
        void RangeContentsChanged(KTextEditor.SmartRange range);
        /// <remarks>
        ///  The contents of the range changed.
        ///  \warning This notification is special in that it is only emitted by
        ///  the top range of a heirachy, and also gives the furthest descendant child range which still
        ///  encompasses the whole change (see <pre>contents</pre>).
        ///  \param range pointer to the range which generated the notification.
        ///  \param mostSpecificChild the child range which both contains the entire change and is
        ///                           the furthest descendant of this range.
        ///      </remarks>        <short>    The contents of the range changed.</short>
        [Q_SIGNAL("void rangeContentsChanged(KTextEditor::SmartRange*, KTextEditor::SmartRange*)")]
        void RangeContentsChanged(KTextEditor.SmartRange range, KTextEditor.SmartRange mostSpecificChild);
        /// <remarks>
        ///  The mouse cursor on \a view entered <pre>range</pre>.
        ///  \todo For now, to receive this notification, the range heirachy must be registered with
        ///  the SmartInterface as for arbitrary highlighting with dynamic highlighting.
        ///  Need to add another (and probably simplify existing) method.
        ///  \param range pointer to the range which generated the notification.
        ///  \param view view over which the mouse moved to generate the notification
        ///      </remarks>        <short>    The mouse cursor on \a view entered \p range.</short>
        [Q_SIGNAL("void mouseEnteredRange(KTextEditor::SmartRange*, KTextEditor::View*)")]
        void MouseEnteredRange(KTextEditor.SmartRange range, KTextEditor.View view);
        /// <remarks>
        ///  The mouse cursor on \a view exited <pre>range</pre>.
        ///  \todo For now, to receive this notification, the range heirachy must be registered with
        ///  the SmartInterface as for arbitrary highlighting with dynamic highlighting.
        ///  Need to add another (and probably simplify existing) method.
        ///  \param range pointer to the range which generated the notification.
        ///  \param view view over which the mouse moved to generate the notification
        ///      </remarks>        <short>    The mouse cursor on \a view exited \p range.</short>
        [Q_SIGNAL("void mouseExitedRange(KTextEditor::SmartRange*, KTextEditor::View*)")]
        void MouseExitedRange(KTextEditor.SmartRange range, KTextEditor.View view);
        /// <remarks>
        ///  The caret on \a view entered <pre>range</pre>.
        ///  \todo For now, to receive this notification, the range heirachy must be registered with
        ///  the SmartInterface as for arbitrary highlighting with dynamic highlighting.
        ///  Need to add another (and probably simplify existing) method.
        ///  \param range pointer to the range which generated the notification.
        ///  \param view view over which the mouse moved to generate the notification
        ///      </remarks>        <short>    The caret on \a view entered \p range.</short>
        [Q_SIGNAL("void caretEnteredRange(KTextEditor::SmartRange*, KTextEditor::View*)")]
        void CaretEnteredRange(KTextEditor.SmartRange range, KTextEditor.View view);
        /// <remarks>
        ///  The caret on \a view exited <pre>range</pre>.
        ///  \todo For now, to receive this notification, the range heirachy must be registered with
        ///  the SmartInterface as for arbitrary highlighting with dynamic highlighting.
        ///  Need to add another (and probably simplify existing) method.
        ///  \param range pointer to the range which generated the notification.
        ///  \param view view over which the mouse moved to generate the notification
        ///      </remarks>        <short>    The caret on \a view exited \p range.</short>
        [Q_SIGNAL("void caretExitedRange(KTextEditor::SmartRange*, KTextEditor::View*)")]
        void CaretExitedRange(KTextEditor.SmartRange range, KTextEditor.View view);
        /// <remarks>
        ///  The range now contains no characters (ie. the start and end cursors are the same).
        ///  \param range pointer to the range which generated the notification.
        ///      </remarks>        <short>    The range now contains no characters (ie.</short>
        [Q_SIGNAL("void rangeEliminated(KTextEditor::SmartRange*)")]
        void RangeEliminated(KTextEditor.SmartRange range);
        /// <remarks>
        ///  The SmartRange instance specified by <pre>range</pre> is being deleted.
        ///  \param range pointer to the range which is about to be deleted.  It is
        ///               still safe to access information at this point.
        ///      </remarks>        <short>    The SmartRange instance specified by \p range is being deleted.</short>
        [Q_SIGNAL("void rangeDeleted(KTextEditor::SmartRange*)")]
        void RangeDeleted(KTextEditor.SmartRange range);
        /// <remarks>
        ///  The range's parent was changed.
        ///  \param range pointer to the range which generated the notification.
        ///  \param newParent pointer to the range which was is now the parent range.
        ///  \param oldParent pointer to the range which used to be the parent range.
        ///      </remarks>        <short>    The range's parent was changed.</short>
        [Q_SIGNAL("void parentRangeChanged(KTextEditor::SmartRange*, KTextEditor::SmartRange*, KTextEditor::SmartRange*)")]
        void ParentRangeChanged(KTextEditor.SmartRange range, KTextEditor.SmartRange newParent, KTextEditor.SmartRange oldParent);
        /// <remarks>
        ///  The range \a child was inserted as a child range into the current \a range.
        ///  \param range pointer to the range which generated the notification.
        ///  \param child pointer to the range which was inserted as a child range.
        ///      </remarks>        <short>    The range \a child was inserted as a child range into the current \a range.</short>
        [Q_SIGNAL("void childRangeInserted(KTextEditor::SmartRange*, KTextEditor::SmartRange*)")]
        void ChildRangeInserted(KTextEditor.SmartRange range, KTextEditor.SmartRange child);
        /// <remarks>
        ///  The child range \a child was removed from the current \a range.
        ///  \param range pointer to the range which generated the notification.
        ///  \param child pointer to the child range which was removed.
        ///      </remarks>        <short>    The child range \a child was removed from the current \a range.</short>
        [Q_SIGNAL("void childRangeRemoved(KTextEditor::SmartRange*, KTextEditor::SmartRange*)")]
        void ChildRangeRemoved(KTextEditor.SmartRange range, KTextEditor.SmartRange child);
        /// <remarks>
        ///  The highlighting attribute of \a range was changed from \a previousAttribute to
        ///  \a currentAttribute.
        ///  \param range pointer to the range which generated the notification.
        ///  \param currentAttribute the attribute newly assigned to this range
        ///  \param previousAttribute the attribute previously assigned to this range
        ///      </remarks>        <short>    The highlighting attribute of \a range was changed from \a previousAttribute to  \a currentAttribute.</short>
        [Q_SIGNAL("void rangeAttributeChanged(KTextEditor::SmartRange*, KTextEditor::Attribute::Ptr, KTextEditor::Attribute::Ptr)")]
        void RangeAttributeChanged(KTextEditor.SmartRange range, KTextEditor.Attribute currentAttribute, KTextEditor.Attribute previousAttribute);
    }
}
