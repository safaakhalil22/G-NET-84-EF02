using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_EF02.Models
{
    internal class OrganizerProfile
    {
        #region OrganizerProfile
        public int OrganizerId { get; set; }
        public string? Biography { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        #region Organizer With OrganizerProfile
        public Organizer Organizer { get; set; } = null!;
        #endregion
        #endregion
    }
}