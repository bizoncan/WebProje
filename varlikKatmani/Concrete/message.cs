﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class message
    {
        [Key]
        public int messageID {  get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
    }
}
