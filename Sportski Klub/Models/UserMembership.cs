using System;
using System.Collections.Generic;
using System.Text;

namespace Sportski_Klub.Models
{
    public class UserMembership
    {
        public User User { get; set; }

        public int UserId { get; set; }

        public Membership Membership { get; set; }

        public int MembershipId { get; set; }

        public DateTime PaidDate { get; set; }
    }
}
