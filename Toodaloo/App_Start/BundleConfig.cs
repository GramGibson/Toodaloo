using System.Web;
using System.Web.Optimization;

namespace Toodaloo {
	public class BundleConfig {
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.Add(new StyleBundle("~/css").Include("~/Content/Css/default.css"));
			bundles.Add(new ScriptBundle("~/js").Include("~/Content/Js/app.js"));
		}
	}
}