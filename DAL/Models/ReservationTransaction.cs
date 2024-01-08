using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ReservationTransaction
    {
        [Key]
        public int ReservationTransactionId { get; set; }

        [ForeignKey("FinancialTransaction")]
        public int FinancialTransactionId { get; set; }
        public virtual FinancialTransaction FinancialTransaction { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
