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
				Id = x.UserId,
				UserName = x.UserName,
				Email = x.Email,
				Password = x.Password
			}).ToList();
		}

		public User CheckUser(string email, string password)
		{
			return _db.Users.SingleOrDefault(x => x.Email == email && x.Password == password);
		}

		public UserAddVM GetUserById(int id)
		{
			return _db.Users.Select(x =>
				new UserAddVM()
				{
					Id = x.UserId,
					UserName = x.UserName,
					Email = x.Email,
					Password = x.Password
				}).SingleOrDefault(x=>x.Id==id);
		}

		public void Update(UserAddVM vm)
		{
			_db.Users.Update( new User()
			{
				UserName = vm.UserName,
				Email = vm.Email,
				Password = vm.Password,
				UserId = vm.Id
			});
			_db.SaveChanges();
		}
	}
}
