using isKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using veriErisimK.EntityFramework;

namespace WebProje.ViewComponents.Dashboard
{
    public class ToDoListDashboard:ViewComponent
    {
        ToDoListManager toDoListManager=new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
