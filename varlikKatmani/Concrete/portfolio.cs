using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class portfolio
    {
        [Key]
        public int portfolioID {  get; set; }
        public string name { get; set; }
        public string imageURL { get; set; }
        public string imageURL2 { get; set; }
        public string projectURL { get; set; }
        public string platform { get; set; }
        public string price { get; set; }
        public bool status { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string img4 { get; set; }
        public int value { get; set; }

    }
}
