using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [ForeignKey("UserId")]
        public virtual Authentication UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }
    }
}