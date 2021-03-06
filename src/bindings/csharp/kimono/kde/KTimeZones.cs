//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  The KTimeZones class represents a time zone database which consists of a
    ///  collection of individual time zone definitions.
    ///  Each individual time zone is defined in a KTimeZone instance, which provides
    ///  generic support for private or system time zones. The time zones in the
    ///  collection are indexed by name, which must be unique within the collection.
    ///  Different time zone sources could define the same time zone differently. (For
    ///  example, a calendar file originating from another system might hold its own
    ///  time zone definitions, which may not necessarily be identical to your own
    ///  system's definitions.) In order to keep conflicting definitions separate,
    ///  it will often be necessary when dealing with multiple time zone sources to
    ///  create a separate KTimeZones instance for each source collection.
    ///  If you want to access system time zones, use the KSystemTimeZones class.
    /// </remarks>        <author> S.R.Haque <srhaque@iee.org>.
    ///  </author>
    ///         <short> Represents a time zone database or collection  @ingroup timezones.</short>
    [SmokeClass("KTimeZones")]
    public class KTimeZones : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KTimeZones(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTimeZones), this);
        }
        public KTimeZones() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTimeZones", "KTimeZones()", typeof(void));
        }
        /// <remarks>
        ///  Returns the time zone with the given name.
        /// <param> name="name" name of time zone
        /// </param></remarks>        <return> time zone, or 0 if not found
        ///      </return>
        ///         <short>    Returns the time zone with the given name.</short>
        public KTimeZone Zone(string name) {
            return (KTimeZone) interceptor.Invoke("zone$", "zone(const QString&) const", typeof(KTimeZone), typeof(string), name);
        }
        /// <remarks>
        ///  Returns all the time zones defined in this collection.
        /// </remarks>        <return> time zone collection
        ///      </return>
        ///         <short>    Returns all the time zones defined in this collection.</short>
        public Dictionary<string, KTimeZone> Zones() {
            return (Dictionary<string, KTimeZone>) interceptor.Invoke("zones", "zones() const", typeof(Dictionary<string, KTimeZone>));
        }
        /// <remarks>
        ///  Adds a time zone to the collection.
        ///  The time zone's name must be unique within the collection.
        /// <param> name="zone" time zone to add
        /// </param></remarks>        <return> @c true if successful, @c false if zone's name duplicates one already in the collection
        /// </return>
        ///         <short>    Adds a time zone to the collection.</short>
        ///         <see> remove</see>
        public bool Add(KTimeZone zone) {
            return (bool) interceptor.Invoke("add#", "add(const KTimeZone&)", typeof(bool), typeof(KTimeZone), zone);
        }
        /// <remarks>
        ///  Removes a time zone from the collection.
        /// <param> name="zone" time zone to remove
        /// </param></remarks>        <return> the time zone which was removed, or invalid if not found
        /// </return>
        ///         <short>    Removes a time zone from the collection.</short>
        ///         <see> clear</see>
        ///         <see> add</see>
        public KTimeZone Remove(KTimeZone zone) {
            return (KTimeZone) interceptor.Invoke("remove#", "remove(const KTimeZone&)", typeof(KTimeZone), typeof(KTimeZone), zone);
        }
        /// <remarks>
        ///  Removes a time zone from the collection.
        /// <param> name="name" name of time zone to remove
        /// </param></remarks>        <return> the time zone which was removed, or invalid if not found
        /// </return>
        ///         <short>    Removes a time zone from the collection.</short>
        ///         <see> clear</see>
        ///         <see> add</see>
        public KTimeZone Remove(string name) {
            return (KTimeZone) interceptor.Invoke("remove$", "remove(const QString&)", typeof(KTimeZone), typeof(string), name);
        }
        /// <remarks>
        ///  Clears the collection.
        /// </remarks>        <short>    Clears the collection.</short>
        ///         <see> remove</see>
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        ~KTimeZones() {
            interceptor.Invoke("~KTimeZones", "~KTimeZones()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KTimeZones", "~KTimeZones()", typeof(void));
        }
    }
}
