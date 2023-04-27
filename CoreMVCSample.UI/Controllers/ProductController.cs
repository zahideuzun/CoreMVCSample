using Microsoft.AspNetCore.Mvc;

namespace CoreMVCSample.UI.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
