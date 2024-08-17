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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TAdd(writerUser t)
        {
            _writerDal.Insert(t);   
        }

        public void TDelete(writerUser t)
        {
           _writerDal.Delete(t);
        }

        public List<writerUser> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public writerUser TGetByID(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<writerUser> TGetList()
        {
            return _writerDal.GetList();
        }

        public void TUpdate(writerUser t)
        {
            _writerDal.Update(t);
        }
    }
}
