using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("EmployeeRoster")]
        public int EmployeeId { get; set; }
        public virtual EmployeeRoster EmployeeRoster { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int AppointmentRoom { get; set; }
    }
}
