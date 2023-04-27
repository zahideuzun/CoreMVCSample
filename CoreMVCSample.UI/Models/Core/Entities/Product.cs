using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class Product
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		

		public List<ProductCategory> ProductCategories { get; set; }
		public List<ProductContent> ProductContents { get; set; }
		public List<UserAllergy> UserAllergies { get; set; }
	}
}
