//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  The <code>CSSCharsetRule</code> interface a <a href=""> \@charset
	///  rule </a> in a CSS style sheet. A <code>\@charset</code> rule can
	///  be used to define the encoding of the style sheet.
	///  </remarks>		<short>    The <code>CSSCharsetRule</code> interface a <a href=""> \@charset  rule </a> in a CSS style sheet.</short>
	[SmokeClass("DOM::CSSCharsetRule")]
	public class CSSCharsetRule : DOM.CSSRule, IDisposable {
 		protected CSSCharsetRule(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(CSSCharsetRule), this);
		}
		// DOM::CSSCharsetRule* CSSCharsetRule(DOM::CSSCharsetRuleImpl* arg1); >>>> NOT CONVERTED
		public CSSCharsetRule() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSCharsetRule", "CSSCharsetRule()", typeof(void));
		}
		public CSSCharsetRule(DOM.CSSCharsetRule other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSCharsetRule#", "CSSCharsetRule(const DOM::CSSCharsetRule&)", typeof(void), typeof(DOM.CSSCharsetRule), other);
		}
		public CSSCharsetRule(DOM.CSSRule other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSCharsetRule#", "CSSCharsetRule(const DOM::CSSRule&)", typeof(void), typeof(DOM.CSSRule), other);
		}
		/// <remarks>
		///  The encoding information used in this <code>\@charset</code>
		///  rule.
		///      </remarks>		<short>    The encoding information used in this <code>\@charset</code>  rule.</short>
		public DOM.DOMString Encoding() {
			return (DOM.DOMString) interceptor.Invoke("encoding", "encoding() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see encoding
		///      </remarks>		<short>    see encoding </short>
		public void SetEncoding(DOM.DOMString arg1) {
			interceptor.Invoke("setEncoding#", "setEncoding(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~CSSCharsetRule() {
			interceptor.Invoke("~CSSCharsetRule", "~CSSCharsetRule()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~CSSCharsetRule", "~CSSCharsetRule()", typeof(void));
		}
	}
}
