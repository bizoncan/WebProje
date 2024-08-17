using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {

            return View(socialMediaManager.TGetList());
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(socialMedia p)
        {
            p.status = true;
            socialMediaManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            socialMediaManager.TDelete(socialMediaManager.TGetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            return View(socialMediaManager.TGetByID(id));
        }
        [HttpPost]
        public IActionResult EditSocialMedia(socialMedia p)
        {
            socialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
