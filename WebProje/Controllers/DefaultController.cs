using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial() 
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult MessageList()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MessageList(message p)
        {
            SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());
            p.date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.status = true;
            sendMessageManager.TAdd(p);
            return PartialView();
        }
    }
}
