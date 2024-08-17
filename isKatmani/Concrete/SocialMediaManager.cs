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

    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(socialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void TDelete(socialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public List<socialMedia> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public socialMedia TGetByID(int id)
        {
           return _socialMediaDal.GetById(id);
        }

        public List<socialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }

        public void TUpdate(socialMedia t)
        {
           _socialMediaDal.Update(t);
        }
    }
}
