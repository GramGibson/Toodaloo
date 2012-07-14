using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Toodaloo.Infrastructure {
	/// <summary>
	/// Requires that the current request was made via ajax,
	/// all other callers will receive a 404
	/// </summary>
	public class RequireAjaxAttribute : ActionFilterAttribute {
		public override void OnActionExecuting(ActionExecutingContext filterContext) {
			if (!filterContext.HttpContext.Request.IsAjaxRequest())
				filterContext.Result = new HttpStatusCodeResult(404);

			base.OnActionExecuting(filterContext);
		}
	}
}