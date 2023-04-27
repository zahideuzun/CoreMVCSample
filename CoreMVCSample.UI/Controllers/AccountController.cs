using System.Threading;
using CoreMVCSample.UI.Models.Core.DAL;
using CoreMVCSample.UI.Models.Core.VM;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCSample.UI.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserDAL _dal;
		public AccountController(UserDAL dal)
		{
			_dal = dal;
		}
		
		public IActionResult Login()
		{
			return View(new UserLoginVM());
		}

		[HttpPost]
		public IActionResult Login(UserLoginVM model)
		{
			return View();
		}
	}
}
