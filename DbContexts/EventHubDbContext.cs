using G_NET_84_EF02.Configurations;
using G_NET_84_EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_EF02.DbContexts
{
    internal class EventHubDbContext : DbContext
    {
        #region EventHubDbContext
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;DataBase=EventHubDb;Trusted_Connection=true;TrustServerCertificate=true");
        //}
        //public DbSet<Organizer> Organizers { get; set; }
        //public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        //public DbSet<Event> Events { get; set; }
        //public DbSet<Attendee> Attendees { get; set; }
        //public DbSet<Badge> Badges { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    #region Organizer And OrganizerProfile One To One
        //    modelBuilder.ApplyConfiguration<OrganizerProfile>(new OrganizerProfileConfigurations());
        //    #endregion

        //    #region Organizer And Event One To Many
        //    modelBuilder.Entity<Event>().ToTable("Events");
        //    modelBuilder.Entity<Event>().HasKey(E => E.Id);
        //    modelBuilder.Entity<Event>().Property(E => E.Title)
        //        .HasMaxLength(200)
        //        .IsRequired();
        //    modelBuilder.Entity<Event>().Property(E => E.Description).IsRequired();
        //    modelBuilder.Entity<Event>().Property(E => E.StartDate).IsRequired();
        //    modelBuilder.Entity<Event>().Property(E => E.EndDate).IsRequired(false);
        //    modelBuilder.Entity<Event>().Property(E => E.MaxAttendees).IsRequired();
        //    modelBuilder.Entity<Event>().ToTable(T => T.HasCheckConstraint("Check_Event_MaxAttendees", "[MaxAttendees] > 0"));
        //    modelBuilder.Entity<Event>().ToTable(T => T.HasCheckConstraint("Check_Event_EndDate", "[EndDate] IS NULL OR [EndDate] >= [StartDate]"));
        //    modelBuilder.Entity<Event>()
        //        .HasOne(E => E.Organizer)
        //        .WithMany(O => O.Events)
        //        .HasForeignKey(E => E.OrganizerId)
        //        .IsRequired()
        //        .OnDelete(DeleteBehavior.Restrict);
        //    #endregion

        //    #region Attendee And Badge One To One
        //    modelBuilder.ApplyConfiguration<Badge>(new BadgeConfigurations());
        //    #endregion
        //}
        #endregion
    }
}