﻿using isKatmani.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listesi";
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill() 
        {
            ViewBag.v1 = "Yetenek Ekleme"; 
            ViewBag.v2 = "Yetenekler"; 
            ViewBag.v3 = "Yetenek Ekleme"; 
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(skill p)
        {
            skillManager.TAdd(p);
            return RedirectToAction("Index");

        }public IActionResult DeleteSkill(int id)
        { 
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index"); 
        }
        [HttpGet]
        public IActionResult EditSkill(int id) 
        {
            ViewBag.v1 = "Yetenek Güncelleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme";
            var values = skillManager.TGetByID(id);
            return View(values);    
        }
        [HttpPost]
        public IActionResult EditSkill(skill skill)
        { 
                skillManager.TUpdate(skill);
                return RedirectToAction("Index");    
        }
     

    }
}


