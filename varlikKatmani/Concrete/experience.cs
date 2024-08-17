using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class experience
    {
        [Key]
        public int experienceID {  get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string imageURL { get; set; }
        public string description  { get; set; }    


    }
}
