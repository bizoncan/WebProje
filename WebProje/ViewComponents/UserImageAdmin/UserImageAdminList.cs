using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using varlikKatmani.Concrete;

namespace WebProje.ViewComponents.UserImageAdmin
{
	public class UserImageAdminList: ViewComponent
	{
		private readonly UserManager<writerUser> _userManager;

		public UserImageAdminList(UserManager<writerUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task< IViewComponentResult> InvokeAsync()
		{
			string p = "admin@gmail.com";
			return View(await _userManager.FindByEmailAsync(p));
		}


	}
}
