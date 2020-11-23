using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public ICollection<ClubUser> UserRolesInClubs { get; set; }
    }
}
