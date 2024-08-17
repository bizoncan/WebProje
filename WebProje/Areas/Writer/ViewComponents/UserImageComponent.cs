using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Threading.Tasks;
using varlikKatmani.Concrete;

namespace WebProje.Areas.Writer.ViewComponents
{
    public class UserImageComponent:ViewComponent
    {
        private readonly UserManager<writerUser> _userManager;

        public UserImageComponent(UserManager<writerUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }
    }
}
