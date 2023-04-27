using System.Reflection.Metadata.Ecma335;
using CoreMVCSample.UI.Models.Core.DAL;
using CoreMVCSample.UI.Models.Core.Entities;
using CoreMVCSample.UI.Models.Core.VM;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCSample.UI.Controllers
{
	public class ProductController : Controller
	{
		private readonly ProductDAL _productDAL;
		public ProductController(ProductDAL product)
		{
			_productDAL = product;
		}
		public IActionResult Index()
		{
			var productList = _productDAL.GetAllProducts();
			return View(productList);
		}
		[HttpGet]
		public IActionResult AddProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddProduct(ProductVM product)
		{
			_productDAL.AddProduct(product);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			_productDAL.GetByIdProduct(id);
			return View();
		}

		[HttpPost]
		public IActionResult UpdateProduct(Product product)
		{
			_productDAL.UpdateProduct(product);
			return RedirectToAction("Index");
		}
	}
}
