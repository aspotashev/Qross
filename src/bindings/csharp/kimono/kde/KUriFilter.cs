//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Text;
    using System.Collections.Generic;
    /// <remarks>
    ///  Manages the filtering of URIs.
    ///  The intention of this plugin class is to allow people to extend the
    ///  functionality of KUrl without modifying it directly. This way KUrl will
    ///  remain a generic parser capable of parsing any generic URL that adheres
    ///  to specifications.
    ///  The KUriFilter class applies a number of filters to a URI and returns the
    ///  filtered version whenever possible. The filters are implemented using
    ///  plugins to provide easy extensibility of the filtering mechanism. New
    ///  filters can be added in the future by simply inheriting from
    ///  KUriFilterPlugin and implementing the KUriFilterPlugin.FilterUri
    ///  method.
    ///  Use of this plugin-manager class is straight forward.  Since it is a
    ///  singleton object, all you have to do is obtain an instance by doing
    ///  <code>KUriFilter</code>.Self() and use any of the public member functions to
    ///  preform the filtering.
    ///  <b></b>xample
    ///  To simply filter a given string:
    ///  <pre>
    ///  bool filtered = KUriFilter.Self().FilterUri( "kde.org" );
    ///  </pre>
    ///  You can alternatively use a KUrl:
    ///  <pre>
    ///  KUrl url = "kde.org";
    ///  bool filtered = KUriFilter.Self().FilterUri( url );
    ///  </pre>
    ///  If you have a constant string or a constant URL, simply invoke the
    ///  corresponding function to obtain the filtered string or URL instead
    ///  of a boolean flag:
    ///  <pre>
    ///  string u = KUriFilter.Self().FilteredUri( "kde.org" );
    ///  </pre>
    ///  You can also restrict the filter(s) to be used by supplying
    ///  the name of the filter(s) to use.  By defualt all available
    ///  filters will be used. To use specific filters, add the names
    ///  of the filters you want to use to a List<string> and invoke
    ///  the appropriate filtering function. The examples below show
    ///  the use of specific filters. The first one uses a single
    ///  filter called kshorturifilter while the second example uses
    ///  multiple filters:
    ///  <pre>
    ///  string text = "kde.org";
    ///  bool filtered = KUriFilter.Self().FilterUri( text, "kshorturifilter" );
    ///  </pre>
    ///  <pre>
    ///  List<string> list;
    ///  list << "kshorturifilter" << "localdomainfilter";
    ///  bool filtered = KUriFilter.Self().FilterUri( text, list );
    ///  </pre>
    ///  KUriFilter also allows richer data exchange through a simple
    ///  meta-object called <code>KUriFilterData.</code> Using this meta-object
    ///  you can find out more information about the URL you want to
    ///  filter. See KUriFilterData for examples and details.
    /// </remarks>        <short> Filters a given URL into its proper format whenever possible.  </short>
    [SmokeClass("KUriFilter")]
    public class KUriFilter : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KUriFilter(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KUriFilter), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KUriFilter() {
            staticInterceptor = new SmokeInvocation(typeof(KUriFilter), null);
        }
        /// <remarks>
        ///  Filters the URI given by the object UriFilterData.
        ///  The given URL is filtered based on the specified list of filters.
        ///  If the list is empty all available filters would be used.
        /// <param> name="data" object that contains the URI to be filtered.
        /// </param><param> name="filters" specify the list of filters to be used.
        /// </param></remarks>        <return> a boolean indicating whether the URI has been changed
        ///      </return>
        ///         <short>    Filters the URI given by the object UriFilterData.</short>
        public bool FilterUri(KUriFilterData data, List<string> filters) {
            return (bool) interceptor.Invoke("filterUri#?", "filterUri(KUriFilterData&, const QStringList&)", typeof(bool), typeof(KUriFilterData), data, typeof(List<string>), filters);
        }
        public bool FilterUri(KUriFilterData data) {
            return (bool) interceptor.Invoke("filterUri#", "filterUri(KUriFilterData&)", typeof(bool), typeof(KUriFilterData), data);
        }
        /// <remarks>
        ///  Filters the URI given by the URL.
        ///  The given URL is filtered based on the specified list of filters.
        ///  If the list is empty all available filters would be used.
        /// <param> name="uri" the URI to filter.
        /// </param><param> name="filters" specify the list of filters to be used.
        /// </param></remarks>        <return> a boolean indicating whether the URI has been changed
        ///      </return>
        ///         <short>    Filters the URI given by the URL.</short>
        public bool FilterUri(KUrl uri, List<string> filters) {
            return (bool) interceptor.Invoke("filterUri#?", "filterUri(KUrl&, const QStringList&)", typeof(bool), typeof(KUrl), uri, typeof(List<string>), filters);
        }
        public bool FilterUri(KUrl uri) {
            return (bool) interceptor.Invoke("filterUri#", "filterUri(KUrl&)", typeof(bool), typeof(KUrl), uri);
        }
        /// <remarks>
        ///  Filters a string representing a URI.
        ///  The given URL is filtered based on the specified list of filters.
        ///  If the list is empty all available filters would be used.
        /// <param> name="uri" The URI to filter.
        /// </param><param> name="filters" specify the list of filters to be used.
        /// </param></remarks>        <return> a boolean indicating whether the URI has been changed
        ///      </return>
        ///         <short>    Filters a string representing a URI.</short>
        public bool FilterUri(StringBuilder uri, List<string> filters) {
            return (bool) interceptor.Invoke("filterUri$?", "filterUri(QString&, const QStringList&)", typeof(bool), typeof(StringBuilder), uri, typeof(List<string>), filters);
        }
        public bool FilterUri(StringBuilder uri) {
            return (bool) interceptor.Invoke("filterUri$", "filterUri(QString&)", typeof(bool), typeof(StringBuilder), uri);
        }
        /// <remarks>
        ///  Returns the filtered URI.
        ///  The given URL is filtered based on the specified list of filters.
        ///  If the list is empty all available filters would be used.
        /// <param> name="uri" The URI to filter.
        /// </param><param> name="filters" specify the list of filters to be used.
        /// </param></remarks>        <return> the filtered URI or null if it cannot be filtered
        ///      </return>
        ///         <short>    Returns the filtered URI.</short>
        public KUrl FilteredUri(KUrl uri, List<string> filters) {
            return (KUrl) interceptor.Invoke("filteredUri#?", "filteredUri(const KUrl&, const QStringList&)", typeof(KUrl), typeof(KUrl), uri, typeof(List<string>), filters);
        }
        public KUrl FilteredUri(KUrl uri) {
            return (KUrl) interceptor.Invoke("filteredUri#", "filteredUri(const KUrl&)", typeof(KUrl), typeof(KUrl), uri);
        }
        /// <remarks>
        ///  Return a filtered string representation of a URI.
        ///  The given URL is filtered based on the specified list of filters.
        ///  If the list is empty all available filters would be used.
        /// <param> name="uri" the URI to filter.
        /// </param><param> name="filters" specify the list of filters to be used.
        /// </param></remarks>        <return> the filtered URI or null if it cannot be filtered
        ///      </return>
        ///         <short>    Return a filtered string representation of a URI.</short>
        public string FilteredUri(string uri, List<string> filters) {
            return (string) interceptor.Invoke("filteredUri$?", "filteredUri(const QString&, const QStringList&)", typeof(string), typeof(string), uri, typeof(List<string>), filters);
        }
        public string FilteredUri(string uri) {
            return (string) interceptor.Invoke("filteredUri$", "filteredUri(const QString&)", typeof(string), typeof(string), uri);
        }
        /// <remarks>
        ///  Return a list of the names of all loaded plugins.
        /// </remarks>        <return> a List<string> of plugin names
        ///      </return>
        ///         <short>    Return a list of the names of all loaded plugins.</short>
        public List<string> PluginNames() {
            return (List<string>) interceptor.Invoke("pluginNames", "pluginNames() const", typeof(List<string>));
        }
        /// <remarks>
        ///  A protected constructor.
        ///  This constructor creates a KUriFilter and
        ///  initializes all plugins it can find by invoking
        ///  loadPlugins.
        ///      </remarks>        <short>    A protected constructor.</short>
        public KUriFilter() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KUriFilter", "KUriFilter()", typeof(void));
        }
        /// <remarks>
        ///  Loads all allowed plugins.
        ///  This function loads all filters that have not
        ///  been disbled.
        ///      </remarks>        <short>    Loads all allowed plugins.</short>
        protected void LoadPlugins() {
            interceptor.Invoke("loadPlugins", "loadPlugins()", typeof(void));
        }
        ~KUriFilter() {
            interceptor.Invoke("~KUriFilter", "~KUriFilter()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KUriFilter", "~KUriFilter()", typeof(void));
        }
        /// <remarks>
        ///  Returns an instance of KUriFilter.
        ///      </remarks>        <short>    Returns an instance of KUriFilter.</short>
        public static KUriFilter Self() {
            return (KUriFilter) staticInterceptor.Invoke("self", "self()", typeof(KUriFilter));
        }
    }
}
