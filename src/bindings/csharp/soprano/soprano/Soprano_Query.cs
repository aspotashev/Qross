//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Query {
    using Soprano;
    using System;
    using Qyoto;
    /// <remarks>
    ///  %Soprano defines a set of well-known query languages that can be used to serialize queries.
    ///  Additional languages may be supported using Query.QueryLanguageUser in combination with
    ///  string codes.
    ///  \sa Model.ExecuteQuery, Query.Parser, Query.Serializer
    ///          </remarks>        <short>    %Soprano defines a set of well-known query languages that can be used to serialize queries.</short>
    public enum QueryLanguage {
        QueryLanguageNone = 0x0,
        QueryLanguageSparql = 0x1,
        QueryLanguageRdql = 0x2,
        QueryLanguageSerql = 0x4,
        QueryLanguageUser = 0x1000,
        QUERY_LANGUAGE_NONE = QueryLanguageNone,
        QUERY_LANGUAGE_SPARQL = QueryLanguageSparql,
        QUERY_LANGUAGE_RDQL = QueryLanguageRdql,
        QUERY_LANGUAGE_SERQL = QueryLanguageSerql,
        QUERY_LANGUAGE_USER = QueryLanguageUser,
    }
    [SmokeClass("Soprano::Query")]
    public class Global {
        private static SmokeInvocation staticInterceptor = null;
        static Global() {
            staticInterceptor = new SmokeInvocation(typeof(Global), null);
        }
        /// <remarks>
        ///  Convert a Soprano.Query.QueryLanguage value into a string representation.
        ///  \param lang The query language to convert
        ///  \param userQueryLanguage If <pre>lang</pre> equals Query.QueryLanguageUser,
        ///  <pre>userQueryLanguage</pre> defines the language to use.
        ///  \return A string representation of <pre>lang</pre>. If <pre>lang</pre> equals Soprano.Query.QueryLanguageUser, the method 
        ///  simply returns <pre>userQueryLanguage</pre>.
        ///          </remarks>        <short>    Convert a Soprano.Query.QueryLanguage value into a string representation.</short>
        public static string QueryLanguageToString(Soprano.Query.QueryLanguage lang, string userQueryLanguage) {
            return (string) staticInterceptor.Invoke("queryLanguageToString$$", "queryLanguageToString(Soprano::Query::QueryLanguage, const QString&)", typeof(string), typeof(Soprano.Query.QueryLanguage), lang, typeof(string), userQueryLanguage);
        }
        public static string QueryLanguageToString(Soprano.Query.QueryLanguage lang) {
            return (string) staticInterceptor.Invoke("queryLanguageToString$", "queryLanguageToString(Soprano::Query::QueryLanguage)", typeof(string), typeof(Soprano.Query.QueryLanguage), lang);
        }
        /// <remarks>
        ///  Convert a query language string into a Soprano.Query.QueryLanguage value.
        ///  \param queryLanguage The query language string to convert.
        ///  \return The QueryLanguage value corresponding to <pre>queryLanguage</pre> or Soprano.Query.QueryLanguageUser if it is unknown.
        ///          </remarks>        <short>    Convert a query language string into a Soprano.Query.QueryLanguage value.</short>
        public static Soprano.Query.QueryLanguage QueryLanguageFromString(string queryLanguage) {
            return (Soprano.Query.QueryLanguage) staticInterceptor.Invoke("queryLanguageFromString$", "queryLanguageFromString(const QString&)", typeof(Soprano.Query.QueryLanguage), typeof(string), queryLanguage);
        }
    }
}
