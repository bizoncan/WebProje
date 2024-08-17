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
    public class FeatureManager : IGenericService<feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public List<feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TAdd(feature t)
        {
           _featureDal.Insert(t);
        }

        public void TDelete(feature t)
        {
            _featureDal.Delete(t);
        }

        public feature TGetByID(int id)
        {
            return _featureDal.GetById(id);
        }

        public void TUpdate(feature t)
        {
            _featureDal.Update(t);
        }

        public List<feature> TGetbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
