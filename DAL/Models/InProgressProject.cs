using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class InProgressProject
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public int ProjectManagerId { get; set; }

        [Required]
        public int EstimatedCost { get; set; }

        [Required]
        public int Balance { get; set; }
    }
}
