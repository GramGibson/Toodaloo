using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Toodaloo.Controllers {
	public class TodoController : Controller {
		public ActionResult Index() {
			return View();
		}
	}
}