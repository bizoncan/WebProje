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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public List<testimonial> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public testimonial TGetByID(int id)
        {
            return  _testimonialDal.GetById(id);
        }

        public List<testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
