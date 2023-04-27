using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		


		public List<UserAllergy> UserAllergies { get; set; }
	}
}
