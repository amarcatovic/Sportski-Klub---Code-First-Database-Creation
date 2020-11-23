using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Tournament
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
