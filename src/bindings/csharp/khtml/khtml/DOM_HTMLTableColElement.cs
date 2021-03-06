//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  Regroups the <code>COL</code> and <code>COLGROUP</code>
	///  elements. See the <a
	///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#edef-COL">
	///  COL element definition </a> in HTML 4.0.
	///  </remarks>		<short>    Regroups the <code>COL</code> and <code>COLGROUP</code>  elements.</short>
	[SmokeClass("DOM::HTMLTableColElement")]
	public class HTMLTableColElement : DOM.HTMLElement, IDisposable {
 		protected HTMLTableColElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLTableColElement), this);
		}
		// DOM::HTMLTableColElement* HTMLTableColElement(DOM::HTMLTableColElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLTableColElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableColElement", "HTMLTableColElement()", typeof(void));
		}
		public HTMLTableColElement(DOM.HTMLTableColElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableColElement#", "HTMLTableColElement(const DOM::HTMLTableColElement&)", typeof(void), typeof(DOM.HTMLTableColElement), other);
		}
		public HTMLTableColElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableColElement#", "HTMLTableColElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  Horizontal alignment of cell data in column. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-align-TD">
		///  align attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Horizontal alignment of cell data in column.</short>
		public DOM.DOMString Align() {
			return (DOM.DOMString) interceptor.Invoke("align", "align() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see align
		///      </remarks>		<short>    see align      </short>
		public void SetAlign(DOM.DOMString arg1) {
			interceptor.Invoke("setAlign#", "setAlign(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Alignment character for cells in a column. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-char">
		///  char attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Alignment character for cells in a column.</short>
		public DOM.DOMString Ch() {
			return (DOM.DOMString) interceptor.Invoke("ch", "ch() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see ch
		///      </remarks>		<short>    see ch      </short>
		public void SetCh(DOM.DOMString arg1) {
			interceptor.Invoke("setCh#", "setCh(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Offset of alignment character. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-charoff">
		///  charoff attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Offset of alignment character.</short>
		public DOM.DOMString ChOff() {
			return (DOM.DOMString) interceptor.Invoke("chOff", "chOff() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see chOff
		///      </remarks>		<short>    see chOff      </short>
		public void SetChOff(DOM.DOMString arg1) {
			interceptor.Invoke("setChOff#", "setChOff(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Indicates the number of columns in a group or affected by a
		///  grouping. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-span-COL">
		///  span attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Indicates the number of columns in a group or affected by a  grouping.</short>
		public long Span() {
			return (long) interceptor.Invoke("span", "span() const", typeof(long));
		}
		/// <remarks>
		///  see span
		///      </remarks>		<short>    see span      </short>
		public void SetSpan(long arg1) {
			interceptor.Invoke("setSpan$", "setSpan(long)", typeof(void), typeof(long), arg1);
		}
		/// <remarks>
		///  Vertical alignment of cell data in column. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-valign">
		///  valign attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Vertical alignment of cell data in column.</short>
		public DOM.DOMString VAlign() {
			return (DOM.DOMString) interceptor.Invoke("vAlign", "vAlign() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see vAlign
		///      </remarks>		<short>    see vAlign      </short>
		public void SetVAlign(DOM.DOMString arg1) {
			interceptor.Invoke("setVAlign#", "setVAlign(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Default column width. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-width-COL">
		///  width attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Default column width.</short>
		public DOM.DOMString Width() {
			return (DOM.DOMString) interceptor.Invoke("width", "width() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see width
		///      </remarks>		<short>    see width      </short>
		public void SetWidth(DOM.DOMString arg1) {
			interceptor.Invoke("setWidth#", "setWidth(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~HTMLTableColElement() {
			interceptor.Invoke("~HTMLTableColElement", "~HTMLTableColElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLTableColElement", "~HTMLTableColElement()", typeof(void));
		}
	}
}
