using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContextDb:DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Vendor> Vendors { get; set; }
    }
}
