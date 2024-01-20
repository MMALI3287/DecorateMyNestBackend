using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ContextDb : DbContext
    {
        //public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<ArchivedProject> ArchivedProjects { get; set; }

        public DbSet<Authentication> Authentications { get; set; }

        public DbSet<Catalog> Catalogs { get; set; }

        public DbSet<CatalogCategory> CatalogCategories { get; set; }

        public DbSet<ChatList> ChatLists { get; set; }

        public DbSet<EmployeeRoster> EmployeeRosters { get; set; }

        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<InProgressProject> InProgressProjects { get; set; }

        public DbSet<InstallmentTransaction> InstallmentTransactions { get; set; }

        public DbSet<MaterialInventory> MaterialInventories { get; set; }

        public DbSet<MaterialTransaction> MaterialTransactions { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<ReservationTransaction> ReservationTransactions { get; set; }

        public DbSet<SalaryTransaction> SalaryTransactions { get; set; }

        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}