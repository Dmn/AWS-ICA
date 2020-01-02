using System;

namespace ThAmCo.Venues.Models
{
    public class AvailabilityGetDto
    {
        //Information obtained from AvailabilityController.
        public string VenueCode { get; set; }

        public string VenueName { get; set; }

        public string Description { get; set; }

        public int Capacity { get; set; }

        public DateTime Date { get; set; }

        public double CostPerHour { get; set; }
    }
}
