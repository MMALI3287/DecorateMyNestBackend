using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ReservationTransactionRepo : Repo, IRepo<ReservationTransaction, int, ReservationTransaction>
    {
        internal ReservationTransactionRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var reservationTransaction = new ReservationTransactionRepo(options);
        }

        public ReservationTransaction Create(ReservationTransaction obj)
        {
            contextDb.ReservationTransactions.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var reservationTransaction = Read(id);
            contextDb.ReservationTransactions.Remove(reservationTransaction);
            return contextDb.SaveChanges() > 0;
        }

        public List<ReservationTransaction> Read()
        {
            return contextDb.ReservationTransactions.ToList();
        }

        public ReservationTransaction Read(int id)
        {
            return contextDb.ReservationTransactions.Find(id);
        }

        public ReservationTransaction Update(ReservationTransaction obj)
        {
            var extReservationTransaction = Read(obj.ReservationTransactionId);
            contextDb.Entry(extReservationTransaction).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
