using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingSharingWebApi.Models
{
    public class Parking
    {
        [Key]
        [Required]
        [MaxLength]
        public string Id { get; set; }

        [Required]
        [MaxLength]
        public string Entry { get; set; }

        [Required]
        [MaxLength]
        public string Spot { get; set; }

        [Required]
        [MaxLength]
        public DateTime ThumbnailUrl { get; set; }
    }
}
