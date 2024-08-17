using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using WebProje.Areas.Writer.Models;

namespace WebProje.Areas.Writer.Controllers
{
    
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<writerUser> _signInManager;

        public LoginController(SignInManager<writerUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
           
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, true, true);
                if (result.Succeeded)
                {
                return RedirectToAction("Index","Default");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                   
            }
            return View(p);

        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }
    }
}
