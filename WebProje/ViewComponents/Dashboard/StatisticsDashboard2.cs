using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading;
using veriErisimK.Concrete;

namespace WebProje.ViewComponents.Dashboard
{
	public class StatisticsDashboard2:ViewComponent
	{
		context c = new context();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = c.Portfolios.Count();
			ViewBag.v2 = c.Messages.Count();
			ViewBag.v3 = c.Services.Count();

			return View();
		}
	}
}
