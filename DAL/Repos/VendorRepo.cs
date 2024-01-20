using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class VendorRepo : Repo, IRepo<Vendor, int, Vendor>
    {
        internal VendorRepo(DbContextOptions<ContextDb> options) : base(options)
        {
            var vendor = new VendorRepo(options);
        }

        public Vendor Create(Vendor obj)
        {
            contextDb.Vendors.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var vendor = Read(id);
            contextDb.Vendors.Remove(vendor);
            return contextDb.SaveChanges() > 0;
        }

        public List<Vendor> Read()
        {
            return contextDb.Vendors.ToList();
        }

        public Vendor Read(int id)
        {
            return contextDb.Vendors.Find(id);
        }

        public Vendor Update(Vendor obj)
        {
            var extVendor = Read(obj.VendorId);
            contextDb.Entry(extVendor).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
