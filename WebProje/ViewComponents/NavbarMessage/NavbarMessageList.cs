using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Linq;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.NavbarMessage
{
	public class NavbarMessageList:ViewComponent
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

		public IViewComponentResult Invoke()
		{
			string p = "admin@gmail.com";

            var values = writerMessageManager.GetListRecieverMessage(p).OrderByDescending(x => x.writerMessageID).Take(3).ToList();
			return View(values);
		}



	}
}
