using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class MaterialTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int MaterialId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int VendorId { get; set; }
    }
}
