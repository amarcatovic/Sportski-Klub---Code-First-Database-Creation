using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        
        public string ImageUrl { get; set; }

        public City City { get; set; }

        [Required]
        public int CityId { get; set; }

        public ICollection<ClubUser> ClubUsers { get; set; }

        public ICollection<UserMembership> UserMemberships { get; set; }
    }
}
