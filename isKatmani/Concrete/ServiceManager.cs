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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(service t)
        {
            _serviceDal.Delete(t);
        }

        public List<service> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public service TGetByID(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(service t)
        {
            _serviceDal.Update(t);
        }
    }
}
