using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme";
            var values = aboutManager.TGetByID(1);

            return View(values);
        }
        [HttpPost]  
        public IActionResult EditAbout(about p)
        {
            aboutManager.TUpdate(p);
            return RedirectToAction("Index","Default");
        }

    }
}
