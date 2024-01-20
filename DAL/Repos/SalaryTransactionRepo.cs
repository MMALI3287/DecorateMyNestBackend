using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class SalaryTransactionRepo : Repo, IRepo<SalaryTransaction, int, SalaryTransaction>
    {
        internal SalaryTransactionRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var salaryTransaction = new SalaryTransactionRepo(options);
        }

        public SalaryTransaction Create(SalaryTransaction obj)
        {
            contextDb.SalaryTransactions.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var salaryTransaction = Read(id);
            contextDb.SalaryTransactions.Remove(salaryTransaction);
            return contextDb.SaveChanges() > 0;
        }

        public List<SalaryTransaction> Read()
        {
            return contextDb.SalaryTransactions.ToList();
        }

        public SalaryTransaction Read(int id)
        {
            return contextDb.SalaryTransactions.Find(id);
        }

        public SalaryTransaction Update(SalaryTransaction obj)
        {
            var extSalaryTransaction = Read(obj.TransactionId);
            contextDb.Entry(extSalaryTransaction).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
