using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sportski_Klub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sportski_Klub.Entity_Framework_Core.EntityConfigs
{
    public class EventClubConfig : IEntityTypeConfiguration<EventClub>
    {
        public void Configure(EntityTypeBuilder<EventClub> builder)
        {
            builder.HasKey(x => new { x.ClubId, x.EventId });

            builder.HasOne(x => x.Event)
                .WithMany(m => m.ClubEvents)
                .HasForeignKey(x => x.EventId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Club)
                .WithMany(m => m.ClubEvents)
                .HasForeignKey(x => x.ClubId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
