using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class annoucement
    {
        [Key]
        public int annoucementID {  get; set; }
        public string title  { get; set; }
        public DateTime date     { get; set; }
        public string status { get; set; }
        public string content { get; set; }
    }
}
