using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {


            return View();
        }
        public IActionResult ListExperience()
        {
            var value = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(value);
        }
        [HttpPost]
        public IActionResult AddExperience(experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
		public IActionResult GetbyID(int id)
		{
            var v = experienceManager.TGetByID(id);
			var values = JsonConvert.SerializeObject(v);
			return Json(values);
		}
		public IActionResult DeleteExperience(int id)
		{
			var v = experienceManager.TGetByID(id);
			experienceManager.TDelete(v);
			return NoContent();
		}
	}
}
