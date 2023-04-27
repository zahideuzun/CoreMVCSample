using CoreMVCSample.UI.Models.Core.DAL;
using CoreMVCSample.UI.Models.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCSample.UI.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CategoryDAL _categoryDAL;
        public CategoryController(CategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public IActionResult Index()
        {
            var categoryList = _categoryDAL.GetCategories();
            return View(categoryList);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryDAL.AddCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int ID)
        {
            Category category = _categoryDAL.GetCategoryByID(ID);
            return View(category);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryDAL.UpdateCategory(category);
            return RedirectToAction("Index");
        }


    }
}
