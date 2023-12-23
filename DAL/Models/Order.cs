using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int VendorId { get; set; }

        [Required]
        public int AdminId { get; set; }

        [Required]
        public int TransactionId { get; set; }

        [Required]
        public bool IsComplete { get; set; }
    }
}
