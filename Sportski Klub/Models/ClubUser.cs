using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sportski_Klub.Models
{
    public class ClubUser
    {
        public Club Club { get; set; }

        [Key]
        public int ClubId { get; set; }

        public User User { get; set; }

        [Key]
        public int UserId { get; set; }

        [Key]
        public Role Role { get; set; }

        public int RoleId { get; set; }

        [Key]
        public DateTime ContractStartDate { get; set; }

        public DateTime ContractEndDate { get; set; }
    }
}
