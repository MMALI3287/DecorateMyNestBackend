using System;

namespace BLL.DTOs
{
    public class FinancialTransactionDTO
    {
        public int TransactionId { get; set; }

        public int Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }
    }
}
