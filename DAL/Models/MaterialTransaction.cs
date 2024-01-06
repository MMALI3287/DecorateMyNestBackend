using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class MaterialTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("MaterialId")]
        public virtual MaterialInventory MaterialId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("VendorId")]
        public virtual Vendor VendorId { get; set; }
    }
}
