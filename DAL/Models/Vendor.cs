using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }
    }
}