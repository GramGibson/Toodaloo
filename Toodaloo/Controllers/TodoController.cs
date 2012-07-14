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
			return View(_ctx.Todos.ToList());
		}

		[HttpPost]
		[RequireAjax]
		public ActionResult Create(Todo todo) {
			todo.LastModified = DateTime.Now;
			_ctx.Todos.Add(todo);
			_ctx.SaveChanges();

			return PartialView("_Created", todo);
		}

		[RequireAjax]
		public ActionResult Edit(int id) {
			var todo = _ctx.Todos.Where(w => w.Id == id).FirstOrDefault();

			return PartialView("_ShowEdit", todo);
		}

		[HttpPost]
		[RequireAjax]
		public ActionResult Edit(int id, Todo todo) {
			var updated = _ctx.Todos.Where(w => w.Id == id).FirstOrDefault();
			UpdateModel(updated);
			updated.LastModified = DateTime.Now;
			_ctx.SaveChanges();

			return PartialView("_Edited", updated);
		}

		[HttpPost]
		[RequireAjax]
		public ActionResult Delete(int id) {
			var todo = _ctx.Todos.Where(w => w.Id == id).FirstOrDefault();
			_ctx.Todos.Remove(todo);

			return PartialView("_Deleted", id);
		}

		protected override void Dispose(bool disposing) {
			_ctx.Dispose();
			base.Dispose(disposing);
		}
	}
}