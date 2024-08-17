using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Contact
{
    public class ContactList: ViewComponent
    {
        ContactDetailsManager contactDetailsManager = new ContactDetailsManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var value = contactDetailsManager.TGetList();
            return View(value);
        }
    }
}
