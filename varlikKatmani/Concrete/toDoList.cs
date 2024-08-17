using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varlikKatmani.Concrete
{
    public class toDoList
    {
        [Key]
        public int toDoListId {  get; set; }
        public string content  { get; set; }
        public bool status  { get; set; }

    }
}
