using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_EF02.Models
{
    internal class Attendee
    {
        #region Attendee
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = null!;
        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = null!;
        [Required]
        [MaxLength(150)]
        public string Street { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string City { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string Country { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; } = null!;
        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}";
        #region Attendee With Badge
        public Badge? Badge { get; set; }
        #endregion
        #endregion
    }
}