//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  The KSystemTimeZones class represents the system time zone database, consisting
    ///  of a collection of individual system time zone definitions, indexed by name.
    ///  Each individual time zone is defined in a KSystemTimeZone instance. Additional
    ///  time zones (of any class derived from KTimeZone) may be added if desired.
    ///  At initialisation, KSystemTimeZones reads the zone.tab file to obtain the list
    ///  of system time zones, and creates a KSystemTimeZone instance for each one.
    ///  Note that KSystemTimeZones is not derived from KTimeZones, but instead contains
    ///  a KTimeZones instance which holds the system time zone database. Convenience
    ///  static methods are defined to access its data, or alternatively you can access
    ///  the KTimeZones instance directly via the timeZones() method.
    ///  As an example, find the local time in Oman corresponding to the local system
    ///  time of 12:15:00 on 13th November 1999:
    ///  <pre>
    ///  QDateTime sampleTime(QDate(1999,11,13), QTime(12,15,0), Qt.LocalTime);
    ///  KTimeZone local = KSystemTimeZones.Local();
    ///  KTimeZone oman  = KSystemTimeZones.Zone("Asia/Muscat");
    ///  QDateTime omaniTime = local.convert(oman, sampleTime);
    ///  </pre>
    ///  @warning The time zones in the KSystemTimeZones collection are by default
    ///  instances of the KSystemTimeZone class, which uses the standard system
    ///  libraries to access time zone data, and whose functionality is limited to
    ///  what these libraries provide. For guaranteed accuracy for past time change
    ///  dates and time zone abbreviations, you should use KSystemTimeZones.ReadZone()
    ///  or the KTzfileTimeZone class instead, which provide accurate information from
    ///  the time zone definition files (but are likely to incur more overhead).
    /// </remarks>        <author> S.R.Haque <srhaque@iee.org>.
    ///  </author>
    ///         <short> System time zone access.</short>
    ///         <see> KTimeZones</see>
    ///         <see> KSystemTimeZone</see>
    ///         <see> KSystemTimeZoneSource</see>
    ///         <see> KTzfileTimeZone</see>
    ///         <see> @ingroup</see>
    ///         <see> timezones</see>
    [SmokeClass("KSystemTimeZones")]
    public class KSystemTimeZones : QObject {
        protected KSystemTimeZones(Type dummy) : base((Type) null) {}
        private static SmokeInvocation staticInterceptor = null;
        static KSystemTimeZones() {
            staticInterceptor = new SmokeInvocation(typeof(KSystemTimeZones), null);
        }
        /// <remarks>
        ///  Returns the unique KTimeZones instance containing the system time zones
        ///  collection. It is first created if it does not already exist.
        /// </remarks>        <return> time zones.
        ///      </return>
        ///         <short>    Returns the unique KTimeZones instance containing the system time zones  collection.</short>
        public static KTimeZones TimeZones() {
            return (KTimeZones) staticInterceptor.Invoke("timeZones", "timeZones()", typeof(KTimeZones));
        }
        /// <remarks>
        ///  Returns all the time zones defined in this collection.
        /// </remarks>        <return> time zone collection
        ///      </return>
        ///         <short>    Returns all the time zones defined in this collection.</short>
        public static Dictionary<string, KTimeZone> Zones() {
            return (Dictionary<string, KTimeZone>) staticInterceptor.Invoke("zones", "zones()", typeof(Dictionary<string, KTimeZone>));
        }
        /// <remarks>
        ///  Returns the time zone with the given name.
        ///  The time zone definition is obtained using system library calls, and may
        ///  not contain historical data. If you need historical time change data,
        ///  use the potentially slower method readZone().
        /// <param> name="name" name of time zone
        /// </param></remarks>        <return> time zone (usually a KSystemTimeZone instance), or invalid if not found
        /// </return>
        ///         <short>    Returns the time zone with the given name.</short>
        ///         <see> readZone</see>
        public static KTimeZone Zone(string name) {
            return (KTimeZone) staticInterceptor.Invoke("zone$", "zone(const QString&)", typeof(KTimeZone), typeof(string), name);
        }
        /// <remarks>
        ///  Returns the time zone with the given name, containing the full time zone
        ///  definition read directly from the system time zone database. This may
        ///  incur a higher overhead than zone(), but will provide whatever historical
        ///  data the system holds.
        /// <param> name="name" name of time zone
        /// </param></remarks>        <return> time zone (usually a KTzfileTimeZone instance), or invalid if not found
        /// </return>
        ///         <short>    Returns the time zone with the given name, containing the full time zone  definition read directly from the system time zone database.</short>
        ///         <see> zone</see>
        public static KTimeZone ReadZone(string name) {
            return (KTimeZone) staticInterceptor.Invoke("readZone$", "readZone(const QString&)", typeof(KTimeZone), typeof(string), name);
        }
        /// <remarks>
        ///  Returns the current local system time zone.
        ///  The idea of this routine is to provide a robust lookup of the local time
        ///  zone. The problem is that on Unix systems, there are a variety of mechanisms
        ///  for setting this information, and no well defined way of getting it. For
        ///  example, if you set your time zone to "Europe/London", then the tzname[]
        ///  maintained by tzset() typically returns { "GMT", "BST" }. The point of
        ///  this routine is to actually return "Europe/London" (or rather, the
        ///  corresponding KTimeZone).
        ///  Note that depending on how the system stores its current time zone, this
        ///  routine may return a synonym of the expected time zone. For example,
        ///  "Europe/London", "Europe/Guernsey" and some other time zones are all
        ///  identical and there may be no way for the routine to distinguish which
        ///  of these is the correct zone name from the user's point of view.
        /// </remarks>        <return> local system time zone. If necessary, we will use a series of
        ///          heuristics which end by returning UTC. We will never return NULL.
        ///          Note that if UTC is returned as a default, it may not belong to the
        ///          the collection returned by KSystemTimeZones.Zones().
        ///      </return>
        ///         <short>    Returns the current local system time zone.</short>
        public static KTimeZone Local() {
            return (KTimeZone) staticInterceptor.Invoke("local", "local()", typeof(KTimeZone));
        }
        /// <remarks>
        ///  Returns the location of the system time zone zoneinfo database.
        /// </remarks>        <return> path of directory containing the zoneinfo database
        ///      </return>
        ///         <short>    Returns the location of the system time zone zoneinfo database.</short>
        public static string ZoneinfoDir() {
            return (string) staticInterceptor.Invoke("zoneinfoDir", "zoneinfoDir()", typeof(string));
        }
        protected new IKSystemTimeZonesSignals Emit {
            get { return (IKSystemTimeZonesSignals) Q_EMIT; }
        }
    }

    public interface IKSystemTimeZonesSignals : IQObjectSignals {
    }
}
