using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client ClientId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual EmployeeRoster EmployeeId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public int AppointmentRoom { get; set; }
    }
}
