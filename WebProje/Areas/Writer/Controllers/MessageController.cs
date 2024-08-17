using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Linq;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Areas.Writer.Controllers
{
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
		private readonly UserManager<writerUser> _userManager ;

        public MessageController(UserManager<writerUser> userManager)
        {
            _userManager = userManager;
        }
		[Route("")]
		[Route("RecieverMessage")]
        public async Task< IActionResult> RecieverMessage(string p)
		{	
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList=writerMessageManager.GetListRecieverMessage(p);	
			return View(messageList);
		}
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(p);
            return View(messageList);
        }
		[HttpGet]
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			return View(values);
		}
		[HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
		{

		return View(); 
		}	
		[HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(writerMessage p)
		{
			context c =new context();
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var email = values.Email;
            p.sender = email;
			var name = values.name + " " + values.surname;
            p.senderName = name;
			p.date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			var usernamesurname = c.Users.Where(x => x.Email == p.reciever).Select(y=>y.name + " " + y.surname).FirstOrDefault();
			p.recieverName = usernamesurname;
			writerMessageManager.TAdd(p);



			return RedirectToAction("SenderMessage");
        }
	}
}
