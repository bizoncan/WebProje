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
    public class ContactDetailsManager:IContactService
    {
        IContactDal _contactDal;

        public ContactDetailsManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(contact t)
        {
            _contactDal.Delete(t);
        }

        public List<contact> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public contact TGetByID(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(contact t)
        {
            _contactDal.Update(t);
        }
    }
}
