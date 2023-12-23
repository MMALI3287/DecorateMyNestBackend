using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class AppoitmentRepo : Repo, IRepo<Appointment, int, Appointment>
    {
        public Appointment Create(Appointment obj)
        {
            contextDb.Appointments.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {

            var appointment = Read(id);
            contextDb.Appointments.Remove(appointment);
            return contextDb.SaveChanges() > 0;
        }

        public List<Appointment> Read()
        {
            return contextDb.Appointments.ToList();
        }

        public Appointment Read(int id)
        {
            return contextDb.Appointments.Find(id);
        }

        public Appointment Update(Appointment obj)
        {
            var extAppointment = Read(obj.AppointmentId);
            contextDb.Entry(extAppointment).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
