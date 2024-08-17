using FluentValidation.Results;
using isKatmani.Concrete;
using isKatmani.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
          
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(portfolio p)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
            }

            return View();
        }
        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
       
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DeletePortfolio(portfolio p, string button)
        {
            if (button == "Sil")
            {
                portfolioManager.TDelete(p);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult EditPortfolio(int id)
        {

            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditPortfolio(portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
                portfolioManager.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
