using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Dashboard
{
	public class Last5Projects:ViewComponent
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		public IViewComponentResult Invoke()
		{
			var values = portfolioManager.TGetLast5();
			return View(values); 
		}
	}
}
