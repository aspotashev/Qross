//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano {
    using Soprano;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \class LiteralValue literalvalue.h Soprano/LiteralValue
    ///  \brief Represents a literal value of an RDF Node.
    ///  LiteralValue is based on QVariant to support
    ///  a subset of the XML Schema types that are compatible
    ///  with QT types.
    ///  The following types are supported natively including
    ///  automatic type conversion. Other types are represented
    ///  as strings.
    ///  <li>int</li> (Vocabulary.XMLSchema.XsdInt)
    ///  <li>qlonglong</li> (Vocabulary.XMLSchema.XsdLong)
    ///  <li>unsigned</li> int (Vocabulary.XMLSchema.UnsignedInt)
    ///  <li>qulonglong</li> (Vocabulary.XMLSchema.UnsignedLong)
    ///  <li>bool</li> (Vocabulary.XMLSchema.Boolean)
    ///  <li>double</li> and float (Vocabulary.XMLSchema.XsdDouble) (float values are always converted to double)
    ///  <li>string</li> (Vocabulary.XMLSchema.String or Vocabulary.RDF.XMLLiteral)
    ///  <li>QDate</li> (Vocabulary.XMLSchema.Date)
    ///  <li>QTime</li> (Vocabulary.XMLSchema.Time)
    ///  <li>QDateTime</li> (Vocabulary.XMLSchema.DateTime)
    ///  <li>QByteArray</li> (Vocabulary.XMLSchema.Base64Binary)
    ///  Literal values can be converted from strings via fromString().
    ///  \warning Be aware that string literals in %Soprano always have type
    ///  xsd:string. There is no direct support for rdfs:Literal. Backend implementations
    ///  should honour this restriction.
    ///  \sa Vocabulary.XMLSchema
    ///  \author Sebastian Trueg <trueg@kde.org>
    ///      </remarks>        <short>    \class LiteralValue literalvalue.</short>
    [SmokeClass("Soprano::LiteralValue")]
    public class LiteralValue : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected LiteralValue(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(LiteralValue), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static LiteralValue() {
            staticInterceptor = new SmokeInvocation(typeof(LiteralValue), null);
        }
        // Soprano::LiteralValue* LiteralValue(const QLatin1String& arg1); >>>> NOT CONVERTED
        /// <remarks>
        ///  Create an empty literal value
        ///          </remarks>        <short>    Create an empty literal value          </short>
        public LiteralValue() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue", "LiteralValue()", typeof(void));
        }
        /// <remarks>
        ///  Default copy constructor
        ///          </remarks>        <short>    Default copy constructor          </short>
        public LiteralValue(Soprano.LiteralValue other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue#", "LiteralValue(const Soprano::LiteralValue&)", typeof(void), typeof(Soprano.LiteralValue), other);
        }
        /// <remarks>
        ///  Creates a new LiteralValue from a QVariant.
        ///  User types are not supported. If v contains an
        ///  unsupported type an invalid LiteralValue is created.
        ///          </remarks>        <short>    Creates a new LiteralValue from a QVariant.</short>
        public LiteralValue(QVariant v) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue#", "LiteralValue(const QVariant&)", typeof(void), typeof(QVariant), v);
        }
        /// <remarks>
        ///  Creates a literal value of type int (i.e.
        ///  http://www.w3.org/2001/XMLSchema#int)
        ///          </remarks>        <short>    Creates a literal value of type int (i.</short>
        public LiteralValue(int i) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue$", "LiteralValue(int)", typeof(void), typeof(int), i);
        }
        /// <remarks>
        ///  Creates a literal value of type long long (i.e.
        ///  http://www.w3.org/2001/XMLSchema#long)
        ///          </remarks>        <short>    Creates a literal value of type long long (i.</short>
        public LiteralValue(long i) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue?", "LiteralValue(qlonglong)", typeof(void), typeof(long), i);
        }
        /// <remarks>
        ///  Creates a literal value of type unsigned int (i.e.
        ///  http://www.w3.org/2001/XMLSchema#unsignedInt)
        ///          </remarks>        <short>    Creates a literal value of type unsigned int (i.</short>
        public LiteralValue(uint i) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue$", "LiteralValue(uint)", typeof(void), typeof(uint), i);
        }
        /// <remarks>
        ///  Creates a literal value of type unsigned long long (i.e.
        ///  http://www.w3.org/2001/XMLSchema#unsignedLong)
        ///          </remarks>        <short>    Creates a literal value of type unsigned long long (i.</short>
        public LiteralValue(ulong i) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue$", "LiteralValue(qulonglong)", typeof(void), typeof(ulong), i);
        }
        /// <remarks>
        ///  Creates a literal value of type bool (i.e.
        ///  http://www.w3.org/2001/XMLSchema#boolean)
        ///          </remarks>        <short>    Creates a literal value of type bool (i.</short>
        public LiteralValue(bool b) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue$", "LiteralValue(bool)", typeof(void), typeof(bool), b);
        }
        /// <remarks>
        ///  Creates a literal value of type double (i.e.
        ///  http://www.w3.org/2001/XMLSchema#double)
        ///          </remarks>        <short>    Creates a literal value of type double (i.</short>
        public LiteralValue(double d) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue$", "LiteralValue(double)", typeof(void), typeof(double), d);
        }
        /// <remarks>
        ///  Creates a literal value of type string (i.e.
        ///  http://www.w3.org/2001/XMLSchema#string)
        ///  \param string The value of the new literal interpreted
        ///  as UTF-8 encoded string.
        ///          </remarks>        <short>    Creates a literal value of type string (i.</short>
        public LiteralValue(string arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue$", "LiteralValue(const char*)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Creates a literal value of type QDate (i.e.
        ///  http://www.w3.org/2001/XMLSchema#date)
        ///          </remarks>        <short>    Creates a literal value of type QDate (i.</short>
        public LiteralValue(QDate date) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue#", "LiteralValue(const QDate&)", typeof(void), typeof(QDate), date);
        }
        /// <remarks>
        ///  Creates a literal value of type QTime (i.e.
        ///  http://www.w3.org/2001/XMLSchema#time)
        ///          </remarks>        <short>    Creates a literal value of type QTime (i.</short>
        public LiteralValue(QTime time) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue#", "LiteralValue(const QTime&)", typeof(void), typeof(QTime), time);
        }
        /// <remarks>
        ///  Creates a literal value of type QDateTime (i.e.
        ///  http://www.w3.org/2001/XMLSchema#dateTime)
        ///          </remarks>        <short>    Creates a literal value of type QDateTime (i.</short>
        public LiteralValue(QDateTime datetime) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue#", "LiteralValue(const QDateTime&)", typeof(void), typeof(QDateTime), datetime);
        }
        /// <remarks>
        ///  Creates a literal value of type QByteArray (i.e.
        ///  http://www.w3.org/2001/XMLSchema#base64Binary)
        ///          </remarks>        <short>    Creates a literal value of type QByteArray (i.</short>
        public LiteralValue(QByteArray data) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("LiteralValue#", "LiteralValue(const QByteArray&)", typeof(void), typeof(QByteArray), data);
        }
        public override bool Equals(object o) {
            if (!(o is LiteralValue)) { return false; }
            return this == (LiteralValue) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public bool IsInt() {
            return (bool) interceptor.Invoke("isInt", "isInt() const", typeof(bool));
        }
        public bool IsInt64() {
            return (bool) interceptor.Invoke("isInt64", "isInt64() const", typeof(bool));
        }
        public bool IsUnsignedInt() {
            return (bool) interceptor.Invoke("isUnsignedInt", "isUnsignedInt() const", typeof(bool));
        }
        public bool IsUnsignedInt64() {
            return (bool) interceptor.Invoke("isUnsignedInt64", "isUnsignedInt64() const", typeof(bool));
        }
        public bool IsBool() {
            return (bool) interceptor.Invoke("isBool", "isBool() const", typeof(bool));
        }
        public bool IsDouble() {
            return (bool) interceptor.Invoke("isDouble", "isDouble() const", typeof(bool));
        }
        /// <remarks>
        ///  Check if the literal contains a string value.
        ///  Be aware that unknown literal types are also
        ///  treated as strings. In that case compare
        ///  dataTypeUrl.
        ///          </remarks>        <short>    Check if the literal contains a string value.</short>
        public bool IsString() {
            return (bool) interceptor.Invoke("isString", "isString() const", typeof(bool));
        }
        public bool IsDate() {
            return (bool) interceptor.Invoke("isDate", "isDate() const", typeof(bool));
        }
        public bool IsTime() {
            return (bool) interceptor.Invoke("isTime", "isTime() const", typeof(bool));
        }
        public bool IsDateTime() {
            return (bool) interceptor.Invoke("isDateTime", "isDateTime() const", typeof(bool));
        }
        public bool IsByteArray() {
            return (bool) interceptor.Invoke("isByteArray", "isByteArray() const", typeof(bool));
        }
        public int ToInt() {
            return (int) interceptor.Invoke("toInt", "toInt() const", typeof(int));
        }
        public long ToInt64() {
            return (long) interceptor.Invoke("toInt64", "toInt64() const", typeof(long));
        }
        public uint ToUnsignedInt() {
            return (uint) interceptor.Invoke("toUnsignedInt", "toUnsignedInt() const", typeof(uint));
        }
        public ulong ToUnsignedInt64() {
            return (ulong) interceptor.Invoke("toUnsignedInt64", "toUnsignedInt64() const", typeof(ulong));
        }
        public bool ToBool() {
            return (bool) interceptor.Invoke("toBool", "toBool() const", typeof(bool));
        }
        public double ToDouble() {
            return (double) interceptor.Invoke("toDouble", "toDouble() const", typeof(double));
        }
        /// <remarks>
        ///  Each type can be converted to a string which means that
        ///  toString in combination with dataTypeUrl provides all the
        ///  information necessary to store this literal as RDF.
        ///  The string value is cached so calling it multiple times in 
        ///  a row is fast.
        ///  \warning For historical reasons this is not a user-readable representation.
        ///  \sa Node.ToString
        ///          </remarks>        <short>    Each type can be converted to a string which means that  toString in combination with dataTypeUrl provides all the  information necessary to store this literal as RDF.</short>
        public new string ToString() {
            return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
        }
        public QDate ToDate() {
            return (QDate) interceptor.Invoke("toDate", "toDate() const", typeof(QDate));
        }
        public QTime ToTime() {
            return (QTime) interceptor.Invoke("toTime", "toTime() const", typeof(QTime));
        }
        public QDateTime ToDateTime() {
            return (QDateTime) interceptor.Invoke("toDateTime", "toDateTime() const", typeof(QDateTime));
        }
        public QByteArray ToByteArray() {
            return (QByteArray) interceptor.Invoke("toByteArray", "toByteArray() const", typeof(QByteArray));
        }
        /// <remarks>
        ///  The XML Schema datatype URI.
        ///  \return The URI of the XML Schema type referring to the
        ///  stored type or an empty QUrl if the LiteralValue is empty.
        ///          </remarks>        <short>    The XML Schema datatype URI.</short>
        public QUrl DataTypeUri() {
            return (QUrl) interceptor.Invoke("dataTypeUri", "dataTypeUri() const", typeof(QUrl));
        }
        /// <remarks>
        ///  The type of the data.
        ///  \return The QVariant type of the stored data or QVariant.Invalid
        ///  if it is an empty value.
        ///          </remarks>        <short>    The type of the data.</short>
        public QVariant.TypeOf type() {
            return (QVariant.TypeOf) interceptor.Invoke("type", "type() const", typeof(QVariant.TypeOf));
        }
        /// <remarks>
        ///  The literal value represented in a QVariant.
        ///  Be aware that the RDF typing information is lost
        ///  in the converted variant.
        ///          </remarks>        <short>    The literal value represented in a QVariant.</short>
        public QVariant Variant() {
            return (QVariant) interceptor.Invoke("variant", "variant() const", typeof(QVariant));
        }
        ~LiteralValue() {
            interceptor.Invoke("~LiteralValue", "~LiteralValue()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~LiteralValue", "~LiteralValue()", typeof(void));
        }
        public static bool operator==(LiteralValue lhs, Soprano.LiteralValue other) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const Soprano::LiteralValue&) const", typeof(bool), typeof(LiteralValue), lhs, typeof(Soprano.LiteralValue), other);
        }
        public static bool operator!=(LiteralValue lhs, Soprano.LiteralValue other) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const Soprano::LiteralValue&) const", typeof(bool), typeof(LiteralValue), lhs, typeof(Soprano.LiteralValue), other);
        }
        /// <remarks>
        ///  Create a LiteralValue object by parsing string \a value based on \a type.
        ///  If \a type is unknown a simple string LiteralValue object is returned
        ///  containing the plain string \a value.
        ///  \sa fromString(string, QUrl)
        ///          </remarks>        <short>    Create a LiteralValue object by parsing string \a value based on \a type.</short>
        public static Soprano.LiteralValue FromString(string value, QVariant.TypeOf type) {
            return (Soprano.LiteralValue) staticInterceptor.Invoke("fromString$$", "fromString(const QString&, QVariant::Type)", typeof(Soprano.LiteralValue), typeof(string), value, typeof(QVariant.TypeOf), type);
        }
        /// <remarks>
        ///  Create a LiteralValue object by parsing string \a value based on \a dataTypeUri.
        ///  \param value The value of the literal. Might be converted based on \a dataTypeUri.
        ///  \param dataTypeUri The data type URI. %Soprano can automatically convert all XML schema
        ///  types. All other (unknown) types will be stored as a string value with the plain
        ///  \a dataTypeUri as type. Thus, unknown literal types can still be used without
        ///  automatic type conversion. (Be aware though, that changing the value of a LiteralValue
        ///  instance will reset the type, ie. custom data type URIs will be lost.)
        ///  Both an empty \a value and \a dataTypeUri will result in an invalid LiteralValue
        ///  instance but an empty \a value with a valid \a dataTypeUri is possible. A valid
        ///  \a value with an invalid \a dataTypeUri will result in a LiteralValue of type
        ///  Vocabulary.XMLSchema.String.
        ///  \return A newly created LiteralValue instance based on the provided \a value and
        ///  \a dataTypeUri.
        ///  \sa fromString(string, QVariant.Type), Vocabulary.XMLSchema
        ///          </remarks>        <short>    Create a LiteralValue object by parsing string \a value based on \a dataTypeUri.</short>
        public static Soprano.LiteralValue FromString(string value, QUrl dataTypeUri) {
            return (Soprano.LiteralValue) staticInterceptor.Invoke("fromString$#", "fromString(const QString&, const QUrl&)", typeof(Soprano.LiteralValue), typeof(string), value, typeof(QUrl), dataTypeUri);
        }
        /// <remarks>
        ///  Convert an XML Schema URI into a QVariant.Type.
        ///  \return The QVariant.Type corresponding to dataTypeUri or QVariant.Invalid
        ///  if dataTypeUri is unknown.
        ///          </remarks>        <short>    Convert an XML Schema URI into a QVariant.Type.</short>
        public static QVariant.TypeOf TypeFromDataTypeUri(QUrl dataTypeUri) {
            return (QVariant.TypeOf) staticInterceptor.Invoke("typeFromDataTypeUri#", "typeFromDataTypeUri(const QUrl&)", typeof(QVariant.TypeOf), typeof(QUrl), dataTypeUri);
        }
        /// <remarks>
        ///  Convert a QVariant.Type into an XML Schema URI.
        ///  \return The XML Schema URI that corresponds to <pre>type</pre> or an empty QUrl if
        ///  the type os unknown, i.e. can not be mapped to an XML Schema type.
        ///          </remarks>        <short>    Convert a QVariant.Type into an XML Schema URI.</short>
        public static QUrl DataTypeUriFromType(QVariant.TypeOf type) {
            return (QUrl) staticInterceptor.Invoke("dataTypeUriFromType$", "dataTypeUriFromType(QVariant::Type)", typeof(QUrl), typeof(QVariant.TypeOf), type);
        }
    }
}
