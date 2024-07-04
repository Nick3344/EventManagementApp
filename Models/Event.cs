using System;

namespace EventManagementApp.Models
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}
