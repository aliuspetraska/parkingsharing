using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingSharingWebApi.Models
{
    public class Log
    {
        [Key]
        [Required]
        [MaxLength]
        public string Id { get; set; }

        [Required]
        [MaxLength]
        public string Timestamp { get; set; }

        [Required]
        [MaxLength]
        public string Action { get; set; }

        [Required]
        [MaxLength]
        public string ParkingId { get; set; }

        [Required]
        [MaxLength]
        public string UserId { get; set; }
    }
}
