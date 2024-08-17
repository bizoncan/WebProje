using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class ErrorPageController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Error404()
		{
			return View();
		}
	}

}
