using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sportski_Klub.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public EventType EventType { get; set; }

        [Required]
        public int EventTypeId { get; set; }

        public Location Location { get; set; }

        [Required]
        public int LocationId { get; set; }

        public EventStatus EventStatus { get; set; }

        [Required]
        public int EventStatusId { get; set; }

        public Tournament Tournament { get; set; }

        [Required]
        public int TournamentId { get; set; }

        [Required]
        public DateTime EventStartDate { get; set; }

        public DateTime EventFinishDate { get; set; }

        public uint Attendance { get; set; }

        public ICollection<EventClub> ClubEvents { get; set; }
    }
}
