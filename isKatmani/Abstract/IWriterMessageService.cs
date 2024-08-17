using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;

namespace isKatmani.Abstract
{
    public interface IWriterMessageService:IGenericService<writerMessage>
    {
        List<writerMessage> GetListSenderMessage(string p);
        List<writerMessage> GetListRecieverMessage(string p);
    }
}
