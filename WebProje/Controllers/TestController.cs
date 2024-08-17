using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
