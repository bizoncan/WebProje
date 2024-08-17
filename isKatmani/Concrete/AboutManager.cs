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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<about> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TAdd(about t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(about t)
        {
            _aboutDal.Delete(t);
        }

        public about TGetByID(int id)
        {
            return  _aboutDal.GetById(id);
        }

        public void TUpdate(about t)
        {
            _aboutDal.Update(t);
        }

        public List<about> TGetbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
