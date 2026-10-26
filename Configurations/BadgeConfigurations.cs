using G_NET_84_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_EF02.Configurations
{
    internal class BadgeConfigurations : IEntityTypeConfiguration<Badge>
    {
        #region BadgeConfigurations
        //public void Configure(EntityTypeBuilder<Badge> builder)
        //{
        //    builder.ToTable("Badges");
        //    builder.HasKey(B => B.Id);
        //    builder.HasIndex(B => B.BadgeNumber).IsUnique();
        //    builder.Property(B => B.IssuedDate).HasDefaultValueSql("GETDATE()");
        //    builder.Property(B => B.Tier)
        //        .HasConversion<string>()
        //        .HasMaxLength(20)
        //        .IsRequired();

        //    #region Attendee With Badge
        //    builder.HasOne(B => B.Attendee)
        //        .WithOne(A => A.Badge)
        //        .HasForeignKey<Badge>(B => B.AttendeeId)
        //        .IsRequired()
        //        .OnDelete(DeleteBehavior.Cascade);
        //    #endregion
        //}
        #endregion
    }
}