using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sportski_Klub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sportski_Klub.Entity_Framework_Core.EntityConfigs
{
    public class ClubUserConfig : IEntityTypeConfiguration<ClubUser>
    {
        public void Configure(EntityTypeBuilder<ClubUser> builder)
        {
            builder.HasKey(x => new { x.ClubId, x.RoleId, x.UserId });

            builder.HasOne(x => x.Club)
                .WithMany(m => m.ClubUsers)
                .HasForeignKey(x => x.ClubId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Role)
                .WithMany(m => m.UserRolesInClubs)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.User)
                .WithMany(m => m.ClubUsers)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
