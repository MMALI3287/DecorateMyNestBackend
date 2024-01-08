using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }

        public string TokenKey { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string UserId { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
