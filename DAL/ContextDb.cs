using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class ContextDb : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Vendor> Vendors { get; set; }
    }
}