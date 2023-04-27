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

		[HttpGet]
		public IActionResult AddOrUpdate(int id)
		{
			if (id!=0)
			{
				return View(_dal.GetUserById(id));
			}

			return View(new UserAddVM());
		}

		[HttpPost]
		public IActionResult AddOrUpdate(UserAddVM vm)
		{
			// id varsa update yoksa add
			if (vm.Id!=0)
			{
				_dal.Update(vm);
			}
			else
			{
				_dal.UserAdd(vm);
			}
			return RedirectToAction("GetAllUsers");
		}

		public IActionResult GetAllUsers()
		{

			return View(_dal.GetAllUser());
		}

		public IActionResult Delete(int Id)
		{
			//_dal.Delete(Id);
			return RedirectToAction("GetAllUsers");

		}
	}
}
