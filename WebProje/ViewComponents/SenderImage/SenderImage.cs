using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using varlikKatmani.Concrete;

namespace WebProje.ViewComponents.SenderImage
{
	public class SenderImage:ViewComponent
	{
		UserManager<writerUser> userManager;

		public SenderImage(UserManager<writerUser> userManager)
		{
			this.userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync(string email)
		{
			
		var u =await userManager.FindByEmailAsync(email);
		
		return View(u); 
		}
	
	}
}

