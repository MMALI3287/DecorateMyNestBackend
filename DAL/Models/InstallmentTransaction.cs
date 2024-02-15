using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class InstallmentTransaction
    {
        [Key]
        public int InstallmentTransactionId { get; set; }

        [ForeignKey("FinancialTransaction")]
        public int TransactionId { get; set; }
        public virtual FinancialTransaction FinancialTransaction { get; set; }

        [ForeignKey("InProgressProject")]
        public int ProjectId { get; set; }
        public virtual InProgressProject InProgressProject { get; set; }

        public int InstallmentNumber { get; set; }

    }
}
