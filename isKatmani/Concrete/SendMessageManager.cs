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
    public class SendMessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public SendMessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(message t)
        {
            _messageDal.Delete(t);
        }

        public List<message> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public message TGetByID(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(message t)
        {
            _messageDal.Update(t);  
        }
    }
}
