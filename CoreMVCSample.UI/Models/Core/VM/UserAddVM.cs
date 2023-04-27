using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace CoreMVCSample.UI.Models.Core.VM
{
	public class UserAddVM
	{
		public int Id { get; set; }
		[DisplayName("Kullanıcı Adı")]
		public string UserName { get; set; }
		[DisplayName("E-Posta")]
		public string Email { get; set; }
		[DisplayName("Şifre")]
		public string Password { get; set; }
	}
}
