using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    public class EventViewModel
    {
        public int CustomerId { get; set; }

        public int EventId { get; set; }

        public string Event { get; set; }

        public bool Attended { get; set; }
    }
}
