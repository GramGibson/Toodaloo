using System.Web.Mvc;

namespace Toodaloo.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return RedirectToAction("", "todo");
		}
	}
}