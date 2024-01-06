using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TokenKey { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime ExpiresAt { get; set; }
    }
}
