using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [ForeignKey("Authentication")]
        public int ReceiverId { get; set; }
        public virtual Authentication Authentication { get; set; }

        public string Content { get; set; }

        public string Type { get; set; }

        public bool IsRead { get; set; }

        public string RedirectUrl { get; set; }
    }
}
