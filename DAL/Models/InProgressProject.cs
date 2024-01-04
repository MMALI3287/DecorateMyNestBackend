using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class InProgressProject
    {
        [Key]
        public int ProjectId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client ClientId { get; set; }

        [ForeignKey("ReservationId")]
        public virtual Reservation ReservationId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [ForeignKey("ProjectManagerId")]
        public virtual EmployeeRoster ProjectManagerId { get; set; }

        [Required]
        public int EstimatedCost { get; set; }

        [Required]
        public int Balance { get; set; }
    }
}
