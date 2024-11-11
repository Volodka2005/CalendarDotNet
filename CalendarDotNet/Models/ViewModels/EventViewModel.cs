using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalendarDotNet.Models.ViewModels
{
    public class EventViewModel
    {
        public Event Event { get; set; }

        public List<SelectListItem> Location { get; set; }  
        public string LocationName { get; set; }

        public EventViewModel(Event myevent, List<Location> locations) 
        {
            Event = myevent;
            LocationName = myevent.Location.Name;
            foreach (var loc in locations)
            {
                Location.Add(new SelectListItem() {Text = loc.Name});
            }
        }

        public EventViewModel(List<Location> locations)
        {
            foreach (var loc in locations)
            {
                Location.Add(new SelectListItem() { Text = loc.Name });
            }
        }
    } 
}
