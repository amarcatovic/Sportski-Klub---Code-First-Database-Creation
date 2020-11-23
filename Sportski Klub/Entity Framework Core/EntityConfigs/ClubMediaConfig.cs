using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sportski_Klub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sportski_Klub.Entity_Framework_Core.EntityConfigs
{
    public class ClubMediaConfig : IEntityTypeConfiguration<ClubMedia>
    {
        public void Configure(EntityTypeBuilder<ClubMedia> builder)
        {
            builder.HasKey(x => new { x.ClubId, x.MediaId, x.PublishDate });

            builder.HasOne(x => x.Club)
                .WithMany(c => c.ClubMedia)
                .HasForeignKey(x => x.ClubId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Media)
                .WithMany(m => m.ClubMedia)
                .HasForeignKey(x => x.MediaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
