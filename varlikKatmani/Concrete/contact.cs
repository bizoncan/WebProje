﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class contact
    {
        [Key]
        public int contactID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
      
    }
}
