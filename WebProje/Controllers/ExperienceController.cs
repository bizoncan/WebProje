using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
      
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(experience p)
        {
            experienceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditExperience(int id)
        {
    
            var values = experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditExperience(experience p)
        {
            experienceManager.TUpdate(p);   
            return RedirectToAction("Index");
        }
    }
}
