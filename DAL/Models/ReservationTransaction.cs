using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class ReservationTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int ReservationId { get; set; }
    }
}
