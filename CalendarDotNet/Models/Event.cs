using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalendarDotNet.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }

        //Relation data
        public virtual Location Location { get; set; }
    }
}
