using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Dashboard
{
    public class VisitedByCountries:ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
