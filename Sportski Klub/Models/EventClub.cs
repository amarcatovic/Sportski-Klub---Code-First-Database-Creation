using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class EventClub
    {
        public Club Club { get; set; }

        [Key]
        public int ClubId { get; set; }

        public Event Event { get; set; }

        [Key]
        public int EventId { get; set; }
    }
}
