using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class MaterialTransaction
    {
        [Key]
        public int MaterialTransactionId { get; set; }

        [ForeignKey("FinancialTransaction")]
        public int TransactionId { get; set; }
        public virtual FinancialTransaction FinancialTransaction { get; set; }

        [ForeignKey("MaterialInventory")]
        public int MaterialId { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public MaterialTransaction()
        {
            Orders = new List<Order>();
        }
    }
}
