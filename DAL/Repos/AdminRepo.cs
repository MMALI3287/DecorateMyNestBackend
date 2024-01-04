// Ignore Spelling: Repos

using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, int, Admin>
    {
        public Admin Create(Admin obj)
        {
            contextDb.Admins.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var admin = Read(id);
            contextDb.Admins.Remove(admin);
            return contextDb.SaveChanges() > 0;
        }

        public List<Admin> Read()
        {
            return contextDb.Admins.ToList();
        }

        public Admin Read(int id)
        {
            return contextDb.Admins.Find(id);
        }

        public Admin Update(Admin obj)
        {
            var extAdmin = Read(obj.AdminId);
            contextDb.Entry(extAdmin).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
