using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class CustomerEventViewModel
    {
        public int CustomerId { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public IEnumerable<EventViewModel> Events { get; set; }
    }
}
