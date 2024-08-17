using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactSubController : Controller
    {
        ContactDetailsManager contactDetailsManager = new ContactDetailsManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            
            return View(contactDetailsManager.TGetByID(1));
        }
       [HttpPost]
        public IActionResult Index(contact p)
        {
            contactDetailsManager.TUpdate(p);

            return RedirectToAction("Index");
        }
    }
}
