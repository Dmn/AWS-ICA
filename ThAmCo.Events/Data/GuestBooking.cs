using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class GuestBooking
    {
        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public int EventId { get; set; }

        public Event Event { get; set; }
        
        public bool Attended { get; set; }
    }
}
