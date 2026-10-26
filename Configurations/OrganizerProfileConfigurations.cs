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
    internal class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        #region OrganizerProfileConfigurations
        //public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        //{
        //    builder.ToTable("OrganizerProfiles");
        //    builder.HasKey(P => P.OrganizerId);
        //    builder.Property(P => P.Biography).HasMaxLength(1000);
        //    builder.Property(P => P.WebsiteUrl).HasMaxLength(300);
        //    builder.Property(P => P.LogoUrl).HasMaxLength(300);

        //    #region Organizer With OrganizerProfile
        //    builder.HasOne(P => P.Organizer)
        //        .WithOne(O => O.Profile)
        //        .HasForeignKey<OrganizerProfile>(P => P.OrganizerId)
        //        .IsRequired()
        //        .OnDelete(DeleteBehavior.Cascade);
        //    #endregion
        //}
        #endregion
    }
}