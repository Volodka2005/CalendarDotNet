using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalendarDotNet.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual required ICollection<Event> Events { get; set; }
    }
}
