using CoreMVCSample.UI.Models.Core.DAL;
using CoreMVCSample.UI.Models.Core.VM;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCSample.UI.Controllers
{
	public class UserController : Controller
	{
		private readonly UserDAL _dal;
		public UserController(UserDAL dal)
		{
			_dal = dal;
		}
		public IActionResult Add()
		{
			return View(new UserAddVM());
		}

		[HttpPost]
		public IActionResult Add(UserAddVM model)
		{
			_dal.UserAdd(model);
			return RedirectToAction("GetAllUsers");
		}

		public IActionResult GetAllUsers()
		{
			return View(_dal.GetAllUser());
		}

	}
}
