using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class InstallmentTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual InProgressProject ProjectId { get; set; }

        [Required]
        public int InstallmentNumber { get; set; }

        [Required]
        public int InstallmentDue { get; set; }
    }
}
