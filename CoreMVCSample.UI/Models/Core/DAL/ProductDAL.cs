using System.Collections.Generic;
using System.Linq;
using CoreMVCSample.UI.Models.Core.Context;
using CoreMVCSample.UI.Models.Core.Entities;

namespace CoreMVCSample.UI.Models.Core.DAL
{
	public class ProductDAL
	{
		private readonly ProductAllergyContext _context;
		ProductDAL(ProductAllergyContext context)
		{
			_context = context;
		}

		public List<Product> GetAllProducts()
		{
			return _context.Products.ToList();
		}

		public void AddProduct(Product product)
		{

		}
	}
}
