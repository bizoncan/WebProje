using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class service
    {
        [Key]
        public int serviceID {  get; set; }
        public string title { get; set; }
        public string imageURL { get; set; }


    }
}
