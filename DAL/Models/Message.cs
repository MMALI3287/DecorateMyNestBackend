using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Message
    {
        [Key]
        public int ChatId { get; set; }

        public string MessageContent { get; set; }

        public DateTime TimeStamp { get; set; }

        [ForeignKey("Authentication")]
        public int SenderId { get; set; }
        public virtual Authentication Authentication { get; set; }

        public int ChatListId { get; set; }
    }
}
