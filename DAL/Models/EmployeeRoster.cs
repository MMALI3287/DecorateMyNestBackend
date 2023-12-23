using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class EmployeeRoster
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Department { get; set; }

        [Required]
        [MaxLength(50)]
        public string Designation { get; set; }

        [Required]
        public int Salary { get; set; }

    }
}
