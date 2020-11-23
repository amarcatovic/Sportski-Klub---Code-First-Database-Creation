using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public Location Location { get; set; }

        [Required]
        public int LocationId { get; set; }

        public ClubType ClubType { get; set; }

        [Required]
        public int ClubTypeId { get; set; }

        public ICollection<EventClub> ClubEvents { get; set; }

        public ICollection<ClubMedia> ClubMedia { get; set; }

        public ICollection<ClubUser> ClubUsers { get; set; }

        public ICollection<Membership> Memberships { get; set; }

    }
}
