using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Domain
{
    public class EventDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Age { get; set; }
        public int Occupancy { get; set; }
        public string PictureUrl { get; set; }
        public string Venue { get; set; }
        public string Date { get; set; }
        public int EventTypeId { get; set; }
        public virtual EventType EventType { get; set; }
        public int EventLocationId { get; set; }
        public virtual EventLocation EventLocation { get; set; }

    }
}