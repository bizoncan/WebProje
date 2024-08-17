using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using varlikKatmani.Concrete;
    using WebProje.Areas.Writer.Models;

    namespace WebProje.Areas.Writer.Controllers

    {
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
        [Route("Writer/[controller]/[action]")] 
    public class ProfileController : Controller
        {
            private readonly UserManager<writerUser> _userManager;

            public ProfileController(UserManager<writerUser> userManager)
            {
                _userManager = userManager;
            }
            [HttpGet]
            public async Task<IActionResult> Index()
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                UserEditViewModel model = new UserEditViewModel();
                model.name = values.name;
                model.surname = values.surname; 
                model.imageURL = values.imageURL;
                return View(model);
            }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var u = await _userManager.FindByNameAsync(User.Identity.Name);
            
            if (p.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveloc = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(saveloc, FileMode.Create);
                await p.image.CopyToAsync(stream);
                u.imageURL = "/userimage/"+imagename;
            }
            u.name = p.name;
            u.surname = p.surname;
            u.PasswordHash = _userManager.PasswordHasher.HashPassword(u, p.password);
            var result = await _userManager.UpdateAsync(u);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
       
         
                return View();
          
            }
        }
    }
 