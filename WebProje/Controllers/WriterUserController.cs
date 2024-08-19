using isKatmani.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager writerUser = new WriterManager(new EfWriterDal());
		private readonly UserManager<writerUser> _userManager;

		public WriterUserController(UserManager<writerUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(_userManager.Users.ToList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(writerUser p)
        {

            writerUser.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);    
        }
		public async Task<IActionResult> DeleteUser(int id)
		{
			var user = await _userManager.FindByIdAsync(id.ToString());
			if (user != null)
			{
				var result = await _userManager.DeleteAsync(user);
				if (result.Succeeded)
				{
					return NoContent();
				}
				return BadRequest("Silme işlemi başarısız oldu.");
			}
			return NotFound("Kullanıcı bulunamadı.");
		}
		public async Task< IActionResult> GetById(int id)
		{
			var user = await _userManager.FindByIdAsync(id.ToString());
			var values = JsonConvert.SerializeObject(user);
			return Json(values);
		}


	}
   
}
