using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class SalaryTransaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }
    }
}
