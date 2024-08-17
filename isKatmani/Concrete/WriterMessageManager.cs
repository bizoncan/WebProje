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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<writerMessage> GetListRecieverMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.reciever == p);
        }

        public List<writerMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.sender == p);
        }

        public void TAdd(writerMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(writerMessage t)
        {
            _writerMessageDal.Delete(t);
        }

    

        public List<writerMessage> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public writerMessage TGetByID(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<writerMessage> TGetList()
        {
            return _writerMessageDal.GetList();
        }

        public void TUpdate(writerMessage t)
        {
           _writerMessageDal.Update(t);
        }
    }
}
