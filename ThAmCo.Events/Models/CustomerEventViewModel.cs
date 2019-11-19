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
        [Required]
        public int Id { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string FullName => FirstName + " " + Surname;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public IEnumerable<EventViewModel> Events { get; set; }
    }
}
