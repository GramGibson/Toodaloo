using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toodaloo.Infrastructure;

namespace Toodaloo.Controllers {
	public class TodoController : ApplicationController {
		public ActionResult Index() {
			return View();
		}
	}
}