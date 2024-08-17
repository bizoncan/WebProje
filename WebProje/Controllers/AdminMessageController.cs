using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<writerUser> _userManager;

        public AdminMessageController(UserManager<writerUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult RecieverMessageList()
        {
            string p = "admin@gmail.com ";
            var values = writerMessageManager.GetListRecieverMessage(p);
            return View(values);
        }
        public IActionResult SeeRecievedMessage(int id)
        {
            return View(writerMessageManager.TGetByID(id));
        }
        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com ";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult SeeSentMessage(int id)
        {
            return View(writerMessageManager.TGetByID(id));
        }
        public IActionResult DeleteAdminMessage(int id,string s)
        {
            writerMessageManager.TDelete(writerMessageManager.TGetByID(id));
            if (s == "sender") { return RedirectToAction("SenderMessageList"); }
            else { return RedirectToAction("RecieverMessageList"); }
            
        }
        [HttpGet]
        public IActionResult SendAdminMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendAdminMessage(writerMessage p)
        {
            context c = new context();

            p.sender = "admin@gmail.com";
            p.senderName = "Admin";
            p.date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var usernamesurname = c.Users.Where(x => x.Email == p.reciever).Select(y => y.name + " " + y.surname).FirstOrDefault();
            p.recieverName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
