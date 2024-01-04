using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("VendorId")]
        public virtual Vendor VendorId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin AdminId { get; set; }

        [ForeignKey("TransactionId")]
        public virtual FinancialTransaction TransactionId { get; set; }

        [Required]
        public bool IsComplete { get; set; }
    }
}
