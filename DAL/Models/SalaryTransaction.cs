using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class SalaryTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual EmployeeRoster EmployeeId { get; set; }
    }
}
