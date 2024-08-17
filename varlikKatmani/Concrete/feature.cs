using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class feature
    {
        [Key]
        public int FeatureID {  get; set; }
        public string Header {  get; set; }
        public string Name   { get; set; }
        public string Title { get; set; }
    }
}
