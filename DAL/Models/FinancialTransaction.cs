using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class FinancialTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }

        public virtual ICollection<InstallmentTransaction> InstallmentTransactions { get; set; }
        public virtual ICollection<ReservationTransaction> ReservationTransactions { get; set; }
        public virtual ICollection<MaterialTransaction> MaterialTransactions { get; set; }
        public virtual ICollection<SalaryTransaction> SalaryTransactions { get; set; }

        public FinancialTransaction()
        {
            InstallmentTransactions = new List<InstallmentTransaction>();
            ReservationTransactions = new List<ReservationTransaction>();
            MaterialTransactions = new List<MaterialTransaction>();
            SalaryTransactions = new List<SalaryTransaction>();
        }
    }
}
