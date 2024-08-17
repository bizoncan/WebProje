using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using veriErisimK.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        context c = new context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x => x.status == false).Count();
            ViewBag.v3 = c.Messages.Where(x => x.status == true).Count();
            ViewBag.v4 = c.Experiences.Count();
          
            return View();
        }
    }
}
