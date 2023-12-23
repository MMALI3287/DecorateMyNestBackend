using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Authentication
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        public byte[] ProfilePicture { get; set; }

        [Required]
        public bool Verified { get; set; }

        [Required]
        public bool Banned { get; set; }

        [Required]
        [MaxLength(50)]
        public string Role { get; set; }
    }
}
