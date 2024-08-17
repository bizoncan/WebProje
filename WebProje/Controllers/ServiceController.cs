using isKatmani.Concrete;
using isKatmani.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
          
            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult AddService(service p)
        {
            serviceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditService(int id)
        {
       
            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditService(service p)
        {
            serviceManager.TUpdate(p);
            return RedirectToAction("Index");

        }




    }
}
