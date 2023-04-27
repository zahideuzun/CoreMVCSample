using CoreMVCSample.UI.Models.Core.Context;
using CoreMVCSample.UI.Models.Core.Entities;

namespace CoreMVCSample.UI.Models.Core.DAL
{
	public class UserDAL
	{
		private readonly ProductAllergyContext _db;
		public UserDAL(ProductAllergyContext db)
		{
			_db = db;
		}

		public void UserAdd(User user)
		{
			_db.Users.Add(user);
		}
		public void CheckUser(string email,string password)
		{

		}
	}
}
