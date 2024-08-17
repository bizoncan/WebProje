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
    
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDall;

        public SkillManager(ISkillDal skillDall)
        {
            _skillDall = skillDall;
        }

        public void TAdd(skill t)
        {
            _skillDall.Insert(t);
        }

        public void TDelete(skill t)
        {
            _skillDall.Delete(t);
        }

        public List<skill> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public skill TGetByID(int id)
        {
            return _skillDall.GetById(id);
        }

        public List<skill> TGetList()
        {
            return _skillDall.GetList();
        }

        public void TUpdate(skill t)
        {
            _skillDall.Update(t);
        }
    }
}


