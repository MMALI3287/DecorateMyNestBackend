﻿namespace BLL.DTOs
{
    internal class InstallmentTransactionDTO
    {
        public int TransactionId { get; set; }

        public int ProjectId { get; set; }

        public int InstallmentNumber { get; set; }

        public int InstallmentDue { get; set; }
    }
}