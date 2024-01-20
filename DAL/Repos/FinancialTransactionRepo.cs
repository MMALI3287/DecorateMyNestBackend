using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class FinancialTransactionRepo : Repo, IRepo<FinancialTransaction, int, FinancialTransaction>
    {
        internal FinancialTransactionRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var financialTransaction = new FinancialTransactionRepo(options);
        }

        public FinancialTransaction Create(FinancialTransaction obj)
        {
            contextDb.FinancialTransactions.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var client = Read(id);
            contextDb.FinancialTransactions.Remove(client);
            return contextDb.SaveChanges() > 0;
        }

        public List<FinancialTransaction> Read()
        {
            return contextDb.FinancialTransactions.ToList();
        }

        public FinancialTransaction Read(int id)
        {
            return contextDb.FinancialTransactions.Find(id);
        }

        public FinancialTransaction Update(FinancialTransaction obj)
        {
            var extFinancialTransaction = Read(obj.TransactionId);
            contextDb.Entry(extFinancialTransaction).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
