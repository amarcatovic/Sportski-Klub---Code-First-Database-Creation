using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Membership
    {
        [Key]
        public int Id { get; set; }

        public Club Club { get; set; }

        [Required]
        public int ClubId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public uint Amount { get; set; }

        [Required]
        public byte MonthsValid { get; set; }

        public ICollection<UserMembership> UserMemberships { get; set; }
    }
}
