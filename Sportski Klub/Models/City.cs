using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Country Country { get; set; }

        [Required]
        public int CountryId { get; set; }

        public ICollection<Location> Locations { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
