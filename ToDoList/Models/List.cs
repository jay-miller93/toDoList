using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        public int ListID { get; set; }
        public string Listtitle { get; set; }
        public DateTime ListCreateDate { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}