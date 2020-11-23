using Microsoft.EntityFrameworkCore;
using Sportski_Klub.Entity_Framework_Core.EntityConfigs;
using Sportski_Klub.Models;

namespace Sportski_Klub.Entity_Framework_Core
{
    public class ClubContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<ClubMedia> ClubMedia { get; set; }

        public DbSet<ClubType> ClubTypes { get; set; }

        public DbSet<ClubUser> ClubUser { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<EventClub> EventClub { get; set; }

        public DbSet<EventStatus> EventStatuses { get; set; }

        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Media> Media { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }


        public ClubContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SBNM27N\\SQLEXPRESS;Initial Catalog=SportskiKlubDB;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClubMediaConfig());
            modelBuilder.ApplyConfiguration(new ClubUserConfig());
            modelBuilder.ApplyConfiguration(new EventClubConfig());
            modelBuilder.ApplyConfiguration(new UserMembershipConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
