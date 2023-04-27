using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class UserAllergy
	{
		public int UserId { get; set; }
		public int ProductId { get; set; }


		public User User { get; set; }
		public Product Product { get; set; }
	}
}
