using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }




    }
}
