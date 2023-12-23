using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class FinancialTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
