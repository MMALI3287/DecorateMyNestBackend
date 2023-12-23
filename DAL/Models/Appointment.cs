using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public int AppointmentRoom { get; set; }
    }
}
