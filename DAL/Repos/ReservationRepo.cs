using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ReservationRepo : Repo, IRepo<Reservation, int, Reservation>
    {
        public Reservation Create(Reservation obj)
        {
            contextDb.Reservations.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var reservation = Read(id);
            contextDb.Reservations.Remove(reservation);
            return contextDb.SaveChanges() > 0;
        }

        public List<Reservation> Read()
        {
            return contextDb.Reservations.ToList();
        }

        public Reservation Read(int id)
        {
            return contextDb.Reservations.Find(id);
        }

        public Reservation Update(Reservation obj)
        {
            var extReservation = Read(obj.ReservationId);
            contextDb.Entry(extReservation).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

    }
}

