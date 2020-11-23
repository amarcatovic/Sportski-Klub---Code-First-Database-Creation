using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sportski_Klub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sportski_Klub.Entity_Framework_Core.EntityConfigs
{
    public class UserMembershipConfig : IEntityTypeConfiguration<UserMembership>
    {
        public void Configure(EntityTypeBuilder<UserMembership> builder)
        {
            builder.HasKey(x => new { x.UserId, x.MembershipId, x.PaidDate });

            builder.HasOne(x => x.Membership)
                .WithMany(m => m.UserMemberships)
                .HasForeignKey(x => x.MembershipId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.User)
                .WithMany(m => m.UserMemberships)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
