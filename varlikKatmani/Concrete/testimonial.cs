using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class testimonial
    {
        [Key]
        public int testimonailID {  get; set; } 
        public string clientName {  get; set; }

        public string company {  get; set; }
        public string comment { get; set; }
        public string imageURL { get; set; }
        public string title { get; set; }
     }
}
