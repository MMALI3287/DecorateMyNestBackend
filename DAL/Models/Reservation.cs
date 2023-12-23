using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
