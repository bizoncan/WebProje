using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialSideBar()
		{
			return PartialView();
		}
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
		public PartialViewResult PartialNavbar() 
		{ 
			return PartialView(); 
		}
		public PartialViewResult PartialHead()
		{
			return PartialView();	
		}
		public PartialViewResult PartialScript() 
		{
			return PartialView();
		}
		public PartialViewResult PartialNavigation()
		{ 
			return PartialView(); 
		}
		public PartialViewResult PartialNewSidebar()
		{

		return PartialView(); 
		}
		public PartialViewResult PartialLastMessages()
		{
			return PartialView();
		}
	

    }
}
