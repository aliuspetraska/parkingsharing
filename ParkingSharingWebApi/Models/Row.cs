using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingSharingWebApi.Models
{
    public class Row
    {
        [Key]
        [Required]
        [MaxLength]
        public string Id { get; set; }

        [Required]
        [MaxLength]
        public string ParkingId { get; set; }

        [Required]
        [MaxLength]
        public DateTime SharedFrom { get; set; }

        [Required]
        [MaxLength]
        public DateTime SharedTo { get; set; }

        [Required]
        [MaxLength]
        public string SharedBy { get; set; }

        [MaxLength]
        public string TakenBy { get; set; }
    }
}
