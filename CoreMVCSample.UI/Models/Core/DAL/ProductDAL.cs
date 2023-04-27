using System.Collections.Generic;
using System.Linq;
using CoreMVCSample.UI.Models.Core.Context;
using CoreMVCSample.UI.Models.Core.Entities;
using CoreMVCSample.UI.Models.Core.VM;

namespace CoreMVCSample.UI.Models.Core.DAL
{
	public class ProductDAL
	{
		private readonly ProductAllergyContext _context;
		public ProductDAL(ProductAllergyContext context)
		{
			_context = context;
		}

		public List<Product> GetAllProducts()
		{
			return _context.Products.ToList();
		}

		public void AddProduct(ProductVM product)
		{
			_context.Products.Add(new Product()
			{
				ProductName = product.ProductName,
				UnitPrice = product.UnitPrice,
			});
			_context.SaveChanges();
		}

		public void UpdateProduct(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
		}

		public Product GetByIdProduct(int id)
		{
			return _context.Products.Where(a=> a.ProductId == id).FirstOrDefault();
		}
		public void DeleteProduct(int id)
		{
			var product = GetByIdProduct(id);
			_context.Products.Remove(product);
			_context.SaveChanges();
		}
	}
}
