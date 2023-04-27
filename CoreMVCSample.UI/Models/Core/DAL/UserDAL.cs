using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CoreMVCSample.UI.Models.Core.Context;
using CoreMVCSample.UI.Models.Core.Entities;
using CoreMVCSample.UI.Models.Core.VM;

namespace CoreMVCSample.UI.Models.Core.DAL
{
	public class UserDAL
	{
		private readonly ProductAllergyContext _db;
		public UserDAL(ProductAllergyContext db)
		{
			_db = db;
		}

		public void UserAdd(UserAddVM user)
		{
			_db.Users.Add(new User()
			{
				UserName = user.UserName,
				Email = user.Email,
				Password = user.Password,
			});
			_db.SaveChanges();
		}

		public List<UserAddVM> GetAllUser()
		{
			return _db.Users.Select(x => new UserAddVM()
			{
				UserName = x.UserName,
				Email = x.Email,
				Password = x.Password
			}).ToList();
		}

		public User CheckUser(string email,string password)
		{
			return _db.Users.Where(x=>x.Email==email && x.Password==password).SingleOrDefault();
		}
	}
}
