using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingSharingWebApi.Models
{
    public class User
    {
        [Key]
        [Required]
        [MaxLength]
        public string Id { get; set; }

        [Required]
        [MaxLength]
        public string UserName { get; set; }

        [MaxLength]
        public string DisplayName { get; set; }

        [MaxLength]
        public string Email { get; set; }

        [MaxLength]
        public string ThumbnailUrl { get; set; }
    }
}
