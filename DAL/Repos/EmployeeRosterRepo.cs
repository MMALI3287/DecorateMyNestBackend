using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class EmployeeRosterRepo : Repo, IRepo<EmployeeRoster, int, EmployeeRoster>
    {

        internal EmployeeRosterRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var employeeRoster = new EmployeeRosterRepo(options);
        }

        public EmployeeRoster Create(EmployeeRoster obj)
        {
            contextDb.EmployeeRosters.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var employeeRoster = Read(id);
            contextDb.EmployeeRosters.Remove(employeeRoster);
            return contextDb.SaveChanges() > 0;
        }

        public List<EmployeeRoster> Read()
        {
            return contextDb.EmployeeRosters.ToList();
        }

        public EmployeeRoster Read(int id)
        {
            return contextDb.EmployeeRosters.Find(id);
        }

        public EmployeeRoster Update(EmployeeRoster obj)
        {
            var extEmployeeRoster = Read(obj.EmployeeId);
            contextDb.Entry(extEmployeeRoster).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
