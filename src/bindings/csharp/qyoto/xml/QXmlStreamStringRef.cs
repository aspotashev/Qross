//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlStreamStringRef")]
	public class QXmlStreamStringRef : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlStreamStringRef(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlStreamStringRef), this);
		}
		//  operator QStringRef(); >>>> NOT CONVERTED
		public QXmlStreamStringRef() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamStringRef", "QXmlStreamStringRef()", typeof(void));
		}
		public QXmlStreamStringRef(string arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamStringRef#", "QXmlStreamStringRef(const QStringRef&)", typeof(void), typeof(string), arg1);
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		~QXmlStreamStringRef() {
			interceptor.Invoke("~QXmlStreamStringRef", "~QXmlStreamStringRef()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QXmlStreamStringRef", "~QXmlStreamStringRef()", typeof(void));
		}
	}
}
