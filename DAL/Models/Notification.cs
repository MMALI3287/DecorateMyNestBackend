using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [ForeignKey("UserId")]
        public virtual Authentication UserId { get; set; }

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
