using isKatmani.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;
using veriErisimK.Abstract;
using veriErisimK.Concrete;

namespace isKatmani.Concrete
{
    public class AnnoucementManager : IAnnoucementService
    {
        IAnnoucementDal _annoucementDal;

        public AnnoucementManager(IAnnoucementDal annoucementDal)
        {
            _annoucementDal = annoucementDal;
        }


		public List<annoucement> Get3Last()
        {
            return _annoucementDal.GetList().OrderByDescending(x => x.annoucementID).Take(3).ToList();
        }
        public void TAdd(annoucement t)
        {
            _annoucementDal.Insert(t);  
        }

        public void TDelete(annoucement t)
        {
            _annoucementDal.Delete(t);
        }

        public List<annoucement> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public annoucement TGetByID(int id)
        {
            return _annoucementDal.GetById(id);
        }

        public List<annoucement> TGetList()
        {
            return _annoucementDal.GetList();
        }

        public void TUpdate(annoucement t)
        {
            _annoucementDal.Update(t);
        }
    }
}
