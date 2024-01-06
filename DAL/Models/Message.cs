using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Message
    {
        [Key]
        public int ChatId { get; set; }

        [Required]
        public string MessageContent { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [ForeignKey("SenderId")]
        public virtual Authentication SenderId { get; set; }
    }
}
