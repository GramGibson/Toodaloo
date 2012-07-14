using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toodaloo.Infrastructure;
using Toodaloo.Models;

namespace Toodaloo.Controllers {
	public class TodoController : ApplicationController {
		private readonly TodoContext _ctx;

		public TodoController() {
			_ctx = new TodoContext();
		}

		public ActionResult Index() {
			return View();
		}

		protected override void Dispose(bool disposing) {
			_ctx.Dispose();
			base.Dispose(disposing);
		}
	}
}