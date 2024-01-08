using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class SalaryTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("EmployeeRoster")]
        public int EmployeeId { get; set; }
        public virtual EmployeeRoster EmployeeRoster { get; set; }
    }
}
