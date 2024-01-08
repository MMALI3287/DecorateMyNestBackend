using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int VendorId { get; set; }

        [ForeignKey("MaterialTransaction")]
        public int MaterialTransactionId { get; set; }
        public virtual MaterialTransaction MaterialTransaction { get; set; }

        public bool IsComplete { get; set; }
    }
}
