using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.Areas.Writer.ViewComponents
{
	public class Notification : ViewComponent
	{
		AnnoucementManager annoucementManager = new AnnoucementManager(new EfAnnoucementDal());
		public IViewComponentResult Invoke()
		{

			return View(annoucementManager.Get3Last());
		}
	}
}
