using System;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public int SenderId { get; set; }
    }
}
