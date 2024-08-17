using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
	{
		SendMessageManager sendMessageManager = new SendMessageManager(new EfMessageDal());
		public IActionResult Index()
		{
			var values = sendMessageManager.TGetList();
			return View(values);
		}
		public IActionResult DeleteMessage(int id)
		{
			sendMessageManager.TDelete(sendMessageManager.TGetByID(id));
			return RedirectToAction("Index");
		}
        public IActionResult SeeMessage(int id)
		{
			return View(sendMessageManager.TGetByID(id));
		}












    }
}
