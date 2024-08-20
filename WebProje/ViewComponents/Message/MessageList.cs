using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Message
{
    public class MessageList : ViewComponent
    {
        SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {

            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(message p)
        //{
        //    p.date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.status = true;
        //    sendMessageManager.TAdd(p);
        //    return View("/Views/Default/Index.cshtml");
        //}
    }
}
