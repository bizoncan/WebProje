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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(experience t)
        {
            _experienceDal.Delete(t);   
        }

        public List<experience> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public experience TGetByID(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<experience> TGetList()
        {
           return _experienceDal.GetList();
        }

        public void TUpdate(experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
