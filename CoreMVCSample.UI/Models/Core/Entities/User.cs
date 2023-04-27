using System.Collections.Generic;

namespace CoreMVCSample.UI.Models.Core.Entities
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }=true;

		public List<UserAllergy> UserAllergies { get; set; }
	}
}
