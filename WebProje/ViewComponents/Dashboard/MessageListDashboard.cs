using isKatmani.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Dashboard
{
	public class MessageListDashboard:ViewComponent
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
		
		public IViewComponentResult Invoke() 
		{

			string p = "admin@gmail.com ";
			var values = writerMessageManager.GetListRecieverMessage(p).OrderByDescending(x=> x.writerMessageID).Take(4).ToList();
			return View(values);
		}
	}
}

