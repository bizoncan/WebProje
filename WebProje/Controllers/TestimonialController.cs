using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {

            return View(testimonialManager.TGetList());
        }
        public IActionResult DeleteTestimonial(int id)
        {

            var values = testimonialManager.TGetByID(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditTestimonial(int id)
        {

            var values = testimonialManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditTestimonial(testimonial p)
        {
            testimonialManager.TUpdate(p);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(testimonial p)
        {
            testimonialManager.TAdd(p);
            return RedirectToAction("Index");

        }
    }

}
