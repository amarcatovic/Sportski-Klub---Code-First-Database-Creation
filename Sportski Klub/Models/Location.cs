using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public string Description { get; set; }

        public City City { get; set; }

        [Required]
        public int CityId { get; set; }

        public ICollection<Club> Clubs { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
