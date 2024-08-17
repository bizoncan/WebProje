using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Service
{
    public class ServiceList: ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var value =serviceManager.TGetList();
            return View(value);
        }


    }
}
