using System.ComponentModel.DataAnnotations;

namespace CalendarDotNet.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        // relational data
        public virtual ICollection<Event> Events { get; set; }
    }

}
