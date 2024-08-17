using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Areas.Writer.Controllers
{
    [Authorize(Roles = "Writer")]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnoucementManager annoucementManager = new AnnoucementManager(new EfAnnoucementDal());
        UserManager<writerUser> _userManager;

        public DefaultController(UserManager<writerUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        { 
            var values = annoucementManager.TGetList();
            var tempval =  _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.img = tempval.imageURL;
            
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnoucementDetails(int id) 
        {
            var values =annoucementManager.TGetByID(id);    
            return View(values);
        }
     
    }
}
