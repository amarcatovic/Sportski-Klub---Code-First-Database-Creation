using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sportski_Klub.Models
{
    public class EventStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
