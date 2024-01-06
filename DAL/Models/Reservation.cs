using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client ClientId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual InProgressProject ProjectId { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
