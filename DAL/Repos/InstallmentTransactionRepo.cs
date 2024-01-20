using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class InstallmentTransactionRepo : Repo, IRepo<InstallmentTransaction, int, InstallmentTransaction>
    {
        internal InstallmentTransactionRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var installmentTransaction = new InstallmentTransactionRepo(options);
        }

        public InstallmentTransaction Create(InstallmentTransaction obj)
        {
            contextDb.InstallmentTransactions.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var installmentTransaction = Read(id);
            contextDb.InstallmentTransactions.Remove(installmentTransaction);
            return contextDb.SaveChanges() > 0;

        }

        public List<InstallmentTransaction> Read()
        {
            return contextDb.InstallmentTransactions.ToList();
        }

        public InstallmentTransaction Read(int id)
        {
            return contextDb.InstallmentTransactions.Find(id);
        }

        public InstallmentTransaction Update(InstallmentTransaction obj)
        {
            var extInstallmentTransaction = Read(obj.TransactionId);
            contextDb.Entry(extInstallmentTransaction).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
