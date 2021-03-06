//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    /// <remarks>
    ///  Base class for the parsed data returned by a KTimeZoneSource class.
    ///  It contains all the data available from the KTimeZoneSource class,
    ///  including, when available, a complete list of daylight savings time
    ///  changes and leap seconds adjustments.
    ///  This base class can be instantiated, but contains no data.
    /// </remarks>        <author> David Jarvie <djarvie@kde.org>.
    ///  </author>
    ///         <short> Base class for parsed time zone data.</short>
    ///         <see> KTimeZone</see>
    ///         <see> KTimeZoneSource</see>
    ///         <see> @ingroup</see>
    ///         <see> timezones</see>
    [SmokeClass("KTimeZoneData")]
    public class KTimeZoneData : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KTimeZoneData(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTimeZoneData), this);
        }
        // QList<KTimeZone::Transition> transitions(const QDateTime& arg1,const QDateTime& arg2); >>>> NOT CONVERTED
        // QList<KTimeZone::Transition> transitions(const QDateTime& arg1); >>>> NOT CONVERTED
        // QList<KTimeZone::Transition> transitions(); >>>> NOT CONVERTED
        // const KTimeZone::Transition* transition(const QDateTime& arg1,const KTimeZone::Transition** arg2,bool* arg3); >>>> NOT CONVERTED
        // const KTimeZone::Transition* transition(const QDateTime& arg1,const KTimeZone::Transition** arg2); >>>> NOT CONVERTED
        // const KTimeZone::Transition* transition(const QDateTime& arg1); >>>> NOT CONVERTED
        // void setTransitions(const QList<KTimeZone::Transition>& arg1); >>>> NOT CONVERTED
        public KTimeZoneData() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTimeZoneData", "KTimeZoneData()", typeof(void));
        }
        public KTimeZoneData(KTimeZoneData c) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTimeZoneData#", "KTimeZoneData(const KTimeZoneData&)", typeof(void), typeof(KTimeZoneData), c);
        }
        /// <remarks>
        ///  Creates a new copy of this object.
        ///  The caller is responsible for deleting the copy.
        ///  Derived classes must reimplement this method to return a copy of the
        ///  calling instance.
        /// </remarks>        <return> copy of this instance
        ///      </return>
        ///         <short>    Creates a new copy of this object.</short>
        [SmokeMethod("clone() const")]
        public virtual KTimeZoneData Clone() {
            return (KTimeZoneData) interceptor.Invoke("clone", "clone() const", typeof(KTimeZoneData));
        }
        /// <remarks>
        ///  Returns the complete list of time zone abbreviations. This may include
        ///  translations.
        /// </remarks>        <return> the list of abbreviations.
        ///          In this base class, it consists of the single string "UTC".
        /// </return>
        ///         <short>    Returns the complete list of time zone abbreviations.</short>
        ///         <see> abbreviation</see>
        [SmokeMethod("abbreviations() const")]
        public virtual List<QByteArray> Abbreviations() {
            return (List<QByteArray>) interceptor.Invoke("abbreviations", "abbreviations() const", typeof(List<QByteArray>));
        }
        /// <remarks>
        ///  Returns the time zone abbreviation current at a specified time.
        /// <param> name="utcDateTime" UTC date/time. An error occurs if
        ///                     <code>utcDateTime.timeSpec</code>() is not Qt.UTC.
        /// </param></remarks>        <return> time zone abbreviation, or empty string if error
        /// </return>
        ///         <short>    Returns the time zone abbreviation current at a specified time.</short>
        ///         <see> abbreviations</see>
        [SmokeMethod("abbreviation(const QDateTime&) const")]
        public virtual QByteArray Abbreviation(QDateTime utcDateTime) {
            return (QByteArray) interceptor.Invoke("abbreviation#", "abbreviation(const QDateTime&) const", typeof(QByteArray), typeof(QDateTime), utcDateTime);
        }
        /// <remarks>
        ///  Returns the complete list of UTC offsets for the time zone, if the time
        ///  zone's source makes such information readily available. If compiling a
        ///  complete list would require significant processing, an empty list is
        ///  returned instead.
        /// </remarks>        <return> sorted list of UTC offsets, or empty list if not readily available.
        ///          In this base class, it consists of the single value 0.
        ///      </return>
        ///         <short>    Returns the complete list of UTC offsets for the time zone, if the time  zone's source makes such information readily available.</short>
        [SmokeMethod("utcOffsets() const")]
        public virtual List<int> UtcOffsets() {
            return (List<int>) interceptor.Invoke("utcOffsets", "utcOffsets() const", typeof(List<int>));
        }
        /// <remarks>
        ///  Returns the UTC offset to use before the start of data for the time zone.
        /// </remarks>        <return> UTC offset
        ///      </return>
        ///         <short>    Returns the UTC offset to use before the start of data for the time zone.</short>
        public int PreviousUtcOffset() {
            return (int) interceptor.Invoke("previousUtcOffset", "previousUtcOffset() const", typeof(int));
        }
        /// <remarks>
        ///  Return all daylight savings time phases.
        ///  Note that some time zone data sources (such as system time zones accessed
        ///  via the system libraries) may not allow a list of daylight savings time
        ///  changes to be compiled easily. In such cases, this method will return an
        ///  empty list.
        /// </remarks>        <return> list of phases
        ///      </return>
        ///         <short>    Return all daylight savings time phases.</short>
        public List<KTimeZone.Phase> Phases() {
            return (List<KTimeZone.Phase>) interceptor.Invoke("phases", "phases() const", typeof(List<KTimeZone.Phase>));
        }
        /// <remarks>
        ///  Return whether daylight saving transitions are available for the time zone.
        ///  The base class returns <code>false.</code>
        /// </remarks>        <return> @c true if transitions are available, @c false if not
        /// </return>
        ///         <short>    Return whether daylight saving transitions are available for the time zone.</short>
        ///         <see> transitions</see>
        ///         <see> transition</see>
        [SmokeMethod("hasTransitions() const")]
        public virtual bool HasTransitions() {
            return (bool) interceptor.Invoke("hasTransitions", "hasTransitions() const", typeof(bool));
        }
        /// <remarks>
        ///  Return all daylight saving transitions, in time order. If desired, the
        ///  transitions returned may be restricted to a specified time range.
        ///  Note that some time zone data sources (such as system time zones accessed
        ///  via the system libraries) may not allow a list of daylight saving time
        ///  changes to be compiled easily. In such cases, this method will return an
        ///  empty list.
        /// <param> name="start" start date/time, or invalid date/time to return all transitions up
        ///               to <code>end.</code> <code>start.timeSpec</code>() must be Qt.UTC, else
        ///               <code>start</code> will be considered invalid.
        /// </param><param> name="end" end date/time, or invalid date/time for no end. <code>end.timeSpec</code>()
        ///                 must be Qt.UTC, else <code>end</code> will be considered invalid.
        /// </param></remarks>        <return> list of transitions, in time order
        /// </return>
        ///         <short>    Return all daylight saving transitions, in time order.</short>
        ///         <see> hasTransitions</see>
        ///         <see> transition</see>
        ///         <see> transitionTimes</see>
        /// <remarks>
        ///  Find the last daylight savings time transition at or before a given
        ///  UTC or local time.
        ///  Because of daylight savings time shifts, a local time may occur twice or
        ///  may not occur at all. In the former case, the transitions at or before
        ///  both occurrences of <code>dt</code> may optionally be calculated and returned in
        ///  <code>secondTransition.</code> The latter case may optionally be detected by use of
        ///  <code>validTime.</code>
        /// <param> name="dt" date/time. <code>dt.timeSpec</code>() may be set to Qt.UTC or Qt.LocalTime.
        /// </param><param> name="secondTransition" if non-null, and the <code>dt</code> occurs twice, receives the
        ///                      transition for the second occurrence. Otherwise, it is set
        ///                      the same as the return value.
        /// </param><param> name="validTime" if non-null, is set to false if <code>dt</code> does not occur, or
        ///                   to true otherwise
        /// </param></remarks>        <return> time zone transition, or null either if <code>dt</code> is either outside the
        ///          defined range of the transition data or if <code>dt</code> does not occur
        /// </return>
        ///         <short>    Find the last daylight savings time transition at or before a given  UTC or local time.</short>
        ///         <see> transitionIndex</see>
        ///         <see> hasTransitions</see>
        ///         <see> transitions</see>
        /// <remarks>
        ///  Find the index to the last daylight savings time transition at or before
        ///  a given UTC or local time. The return value is the index into the transition
        ///  list returned by transitions().
        ///  Because of daylight savings time shifts, a local time may occur twice or
        ///  may not occur at all. In the former case, the transitions at or before
        ///  both occurrences of <code>dt</code> may optionally be calculated and returned in
        ///  <code>secondIndex.</code> The latter case may optionally be detected by use of
        ///  <code>validTime.</code>
        /// <param> name="dt" date/time. <code>dt.timeSpec</code>() may be set to Qt.UTC or Qt.LocalTime.
        /// </param><param> name="secondIndex" if non-null, and the <code>dt</code> occurs twice, receives the
        ///                     index to the transition for the second occurrence. Otherwise,
        ///                     it is set the same as the return value.
        /// </param><param> name="validTime" if non-null, is set to false if <code>dt</code> does not occur, or
        ///                   to true otherwise
        /// </param></remarks>        <return> index into the time zone transition list, or -1 either if <code>dt</code> is
        ///          either outside the defined range of the transition data or if <code>dt</code>
        ///          does not occur
        /// </return>
        ///         <short>    Find the index to the last daylight savings time transition at or before  a given UTC or local time.</short>
        ///         <see> transition</see>
        ///         <see> transitions</see>
        ///         <see> hasTransitions</see>
        public int TransitionIndex(QDateTime dt, ref int secondIndex, ref bool validTime) {
            StackItem[] stack = new StackItem[4];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(dt);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(dt);
#endif
            stack[2].s_int = secondIndex;
            stack[3].s_bool = validTime;
            interceptor.Invoke("transitionIndex#$$", "transitionIndex(const QDateTime&, int*, bool*) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
            secondIndex = stack[2].s_int;
            validTime = stack[3].s_bool;
            return stack[0].s_int;
        }
        public int TransitionIndex(QDateTime dt, ref int secondIndex) {
            StackItem[] stack = new StackItem[3];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(dt);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(dt);
#endif
            stack[2].s_int = secondIndex;
            interceptor.Invoke("transitionIndex#$", "transitionIndex(const QDateTime&, int*) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
            secondIndex = stack[2].s_int;
            return stack[0].s_int;
        }
        public int TransitionIndex(QDateTime dt) {
            return (int) interceptor.Invoke("transitionIndex#", "transitionIndex(const QDateTime&) const", typeof(int), typeof(QDateTime), dt);
        }
        /// <remarks>
        ///  Return the times of all daylight saving transitions to a given time zone
        ///  phase, in time order. If desired, the times returned may be restricted to
        ///  a specified time range.
        ///  Note that some time zone data sources (such as system time zones accessed
        ///  via the system libraries) may not allow a list of daylight saving time
        ///  changes to be compiled easily. In such cases, this method will return an
        ///  empty list.
        /// <param> name="phase" time zone phase
        /// </param><param> name="start" start UTC date/time, or invalid date/time to return all transitions
        ///               up to <code>end.</code> <code>start.timeSpec</code>() must be Qt.UTC, else
        ///               <code>start</code> will be considered invalid.
        /// </param><param> name="end" end UTC date/time, or invalid date/time for no end. <code>end.timeSpec</code>()
        ///                 must be Qt.UTC, else <code>end</code> will be considered invalid.
        /// </param></remarks>        <return> ordered list of transition times
        /// </return>
        ///         <short>    Return the times of all daylight saving transitions to a given time zone  phase, in time order.</short>
        ///         <see> hasTransitions</see>
        ///         <see> transition</see>
        ///         <see> transitions</see>
        public List<QDateTime> TransitionTimes(KTimeZone.Phase phase, QDateTime start, QDateTime end) {
            return (List<QDateTime>) interceptor.Invoke("transitionTimes###", "transitionTimes(const KTimeZone::Phase&, const QDateTime&, const QDateTime&) const", typeof(List<QDateTime>), typeof(KTimeZone.Phase), phase, typeof(QDateTime), start, typeof(QDateTime), end);
        }
        public List<QDateTime> TransitionTimes(KTimeZone.Phase phase, QDateTime start) {
            return (List<QDateTime>) interceptor.Invoke("transitionTimes##", "transitionTimes(const KTimeZone::Phase&, const QDateTime&) const", typeof(List<QDateTime>), typeof(KTimeZone.Phase), phase, typeof(QDateTime), start);
        }
        public List<QDateTime> TransitionTimes(KTimeZone.Phase phase) {
            return (List<QDateTime>) interceptor.Invoke("transitionTimes#", "transitionTimes(const KTimeZone::Phase&) const", typeof(List<QDateTime>), typeof(KTimeZone.Phase), phase);
        }
        /// <remarks>
        ///  Return all leap second adjustments, in time order.
        ///  Note that some time zone data sources (such as system time zones accessed
        ///  via the system libraries) may not provide information on leap second
        ///  adjustments. In such cases, this method will return an empty list.
        /// </remarks>        <return> list of adjustments
        ///      </return>
        ///         <short>    Return all leap second adjustments, in time order.</short>
        public List<KTimeZone.LeapSeconds> LeapSecondChanges() {
            return (List<KTimeZone.LeapSeconds>) interceptor.Invoke("leapSecondChanges", "leapSecondChanges() const", typeof(List<KTimeZone.LeapSeconds>));
        }
        /// <remarks>
        ///  Find the leap second adjustment which is applicable at a given UTC time.
        /// <param> name="utc" UTC date/time. An error occurs if <code>utc.timeSpec</code>() is not Qt.UTC.
        /// </param></remarks>        <return> leap second adjustment, or invalid if <code>utc</code> is earlier than the
        ///          first leap second adjustment or <code>utc</code> is a local time
        ///      </return>
        ///         <short>    Find the leap second adjustment which is applicable at a given UTC time.</short>
        public KTimeZone.LeapSeconds LeapSecondChange(QDateTime utc) {
            return (KTimeZone.LeapSeconds) interceptor.Invoke("leapSecondChange#", "leapSecondChange(const QDateTime&) const", typeof(KTimeZone.LeapSeconds), typeof(QDateTime), utc);
        }
        /// <remarks>
        ///  Initialise the daylight savings time phase list.
        /// <param> name="phases" list of phases
        /// </param><param> name="previousUtcOffset" UTC offset to use before the start of the first
        ///                           phase
        /// </param></remarks>        <short>    Initialise the daylight savings time phase list.</short>
        ///         <see> phases</see>
        protected void SetPhases(List<KTimeZone.Phase> phases, int previousUtcOffset) {
            interceptor.Invoke("setPhases?$", "setPhases(const QList<KTimeZone::Phase>&, int)", typeof(void), typeof(List<KTimeZone.Phase>), phases, typeof(int), previousUtcOffset);
        }
        /// <remarks>
        ///  Initialise the daylight savings time transition list.
        /// <param> name="transitions" list of transitions
        /// </param></remarks>        <short>    Initialise the daylight savings time transition list.</short>
        ///         <see> transitions</see>
        /// <remarks>
        ///  Initialise the leap seconds adjustment list.
        /// <param> name="adjusts" list of adjustments
        /// </param></remarks>        <short>    Initialise the leap seconds adjustment list.</short>
        ///         <see> leapSecondChanges</see>
        protected void SetLeapSecondChanges(List<KTimeZone.LeapSeconds> adjusts) {
            interceptor.Invoke("setLeapSecondChanges?", "setLeapSecondChanges(const QList<KTimeZone::LeapSeconds>&)", typeof(void), typeof(List<KTimeZone.LeapSeconds>), adjusts);
        }
        ~KTimeZoneData() {
            interceptor.Invoke("~KTimeZoneData", "~KTimeZoneData()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KTimeZoneData", "~KTimeZoneData()", typeof(void));
        }
    }
}
