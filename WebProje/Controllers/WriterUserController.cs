using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager writerUser = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUser.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(writerUser p)
        {
            writerUser.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);    
        }
	}
   
}
