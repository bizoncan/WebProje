using isKatmani.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.Abstract;

namespace isKatmani.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(toDoList t)
        {
            _toDoListDal.Insert(t);
        }

        public void TDelete(toDoList t)
        {
            _toDoListDal.Delete(t);
        }

        public List<toDoList> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public toDoList TGetByID(int id)
        {
            return _toDoListDal.GetById(id);
        }

        public List<toDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void TUpdate(toDoList t)
        {
            _toDoListDal.Update(t);
        }
    }
}
