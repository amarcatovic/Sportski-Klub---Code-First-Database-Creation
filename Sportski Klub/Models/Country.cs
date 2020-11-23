using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string FlagImageUrl { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
