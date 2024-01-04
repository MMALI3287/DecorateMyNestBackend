using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class EmployeeRoster
    {
        [Key]
        public int EmployeeId { get; set; }

        [ForeignKey("UserId")]
        public virtual Authentication UserId { get; set; }

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
