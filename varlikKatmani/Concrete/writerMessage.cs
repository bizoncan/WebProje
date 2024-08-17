using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
	public class writerMessage
	{
        [Key]
        public int writerMessageID { get; set; }
        public string sender { get; set; }
        public string reciever { get; set; }
        public string senderName { get; set; }
        public string recieverName { get; set; }
        public string  subject { get; set; }
        public string messageContent { get; set; }
        public DateTime date { get; set; }  

    }
}
