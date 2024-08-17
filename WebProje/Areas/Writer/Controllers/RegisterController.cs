using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using WebProje.Areas.Writer.Models;

namespace WebProje.Areas.Writer.Controllers
{
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<writerUser> _userManager;

        public RegisterController(UserManager<writerUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                writerUser w = new writerUser()
                {
                    name = p.name,
                    surname = p.surname,
                    UserName = p.userName,
                    Email = p.mail,
                    imageURL = p.imageURL,


                };
                if (p.password == p.confirmPassword)
                {
                    var results = await _userManager.CreateAsync(w, p.password);
                    if (results.Succeeded)
                    {
                        return RedirectToAction("Index","Login");
                    }
                    else
                    {
                        foreach (var item in results.Errors)
                        {
                            ModelState.AddModelError("", item.Description);

                        }
                    }

                }
                }
            return View();
        }
    }
}
//ssvasvtrtbertgA?123