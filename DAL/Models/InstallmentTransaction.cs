using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class InstallmentTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public int InstallmentNumber { get; set; }

        [Required]
        public int InstallmentDue { get; set; }
    }
}
