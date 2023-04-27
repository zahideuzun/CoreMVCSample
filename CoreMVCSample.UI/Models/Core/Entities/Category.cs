using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }


		public List<ProductCategory> ProductCategories { get; set; }
	}
}
