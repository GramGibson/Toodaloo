using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toodaloo.Helpers {
	public static class Extensions {
		public static HtmlString EscapeJavascript(this HtmlString text) {
			return new HtmlString(text
				 .ToHtmlString()
				 .Replace("\r\n", string.Empty)
				 .Replace("\n", string.Empty)
				 .Replace("\r", string.Empty)
				 .Replace("</", @"<\/")
				 .Replace("'", "\\'")
				 .Replace("\"", "\\\""));
		}
	}
}