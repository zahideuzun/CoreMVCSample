using Microsoft.AspNetCore.Mvc;

namespace CoreMVCSample.UI.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
