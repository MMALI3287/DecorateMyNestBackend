using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Content { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        public bool IsRead { get; set; }

        [Required]
        [MaxLength(200)]
        public string RedirectUrl { get; set; }
    }
}
