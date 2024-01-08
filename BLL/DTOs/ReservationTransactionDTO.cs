namespace BLL.DTOs
{
    public class ReservationTransactionDTO
    {
        public int ReservationTransactionId { get; set; }

        public int FinancialTransactionId { get; set; }

        public int ReservationId { get; set; }
    }
}
