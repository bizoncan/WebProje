using isKatmani.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.EntityFramework;

namespace WebProje.Areas.Writer.ViewComponents
{
    public class MessageImage:ViewComponent
    {
        private readonly UserManager<writerUser> _userManager;

        public MessageImage(UserManager<writerUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task< IViewComponentResult> InvokeAsync(string mail)
        {
            if (IsValidEmail(mail))
            {
                var user = await _userManager.FindByEmailAsync(mail);
                return View(user);
            }

            // Handle invalid email format case (e.g., return a default view or error message)
            return View("InvalidEmailFormat");
        }
        private bool IsValidEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
