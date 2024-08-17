using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IViewComponentResult Invoke()
        {
            return View(socialMediaManager.TGetList());
        }
    }
}
