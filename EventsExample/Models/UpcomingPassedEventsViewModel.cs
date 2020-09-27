namespace EventsExample.Models
{
    using System.Collections.Generic;

    public class UpcomingPassedEventsViewModel
    {
        public IEnumerable<EventViewModel> UpcomingEvents { get; set; }
        
        public IEnumerable<EventViewModel> PassedEvents { get; set; }
    }
}