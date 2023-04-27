using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.VM
{
	public class ProductVM
	{
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		public List<int> CategoryIds { get; set; }

	}
}
