using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.About
{
	public class AboutList: ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		public IViewComponentResult Invoke()
		{
			var values = aboutManager.TGetList();
			return View(values);
		}
	}
}
