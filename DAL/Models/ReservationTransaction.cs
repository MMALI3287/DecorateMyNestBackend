using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ReservationTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("ReservationId")]
        public virtual Reservation ReservationId { get; set; }
    }
}
