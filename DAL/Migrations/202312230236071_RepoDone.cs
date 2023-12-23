namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RepoDone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                {
                    AppointmentId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    EmployeeId = c.Int(nullable: false),
                    AppointmentDate = c.DateTime(nullable: false),
                    AppointmentRoom = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.AppointmentId);

            CreateTable(
                "dbo.ArchivedProjects",
                c => new
                {
                    ProjectId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    CompletionDate = c.DateTime(nullable: false),
                    Review = c.String(nullable: false, maxLength: 100),
                    Rating = c.Int(nullable: false),
                    Revenue = c.Int(nullable: false),
                    Picture = c.Binary(),
                })
                .PrimaryKey(t => t.ProjectId);

            CreateTable(
                "dbo.Authentications",
                c => new
                {
                    UserId = c.Int(nullable: false, identity: true),
                    UserName = c.String(nullable: false, maxLength: 50),
                    Password = c.String(nullable: false, maxLength: 50),
                    FirstName = c.String(nullable: false, maxLength: 50),
                    LastName = c.String(nullable: false, maxLength: 50),
                    EmailAddress = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 50),
                    ProfilePicture = c.Binary(nullable: false),
                    Verified = c.Boolean(nullable: false),
                    Banned = c.Boolean(nullable: false),
                    Role = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.UserId);

            CreateTable(
                "dbo.CatalogCategories",
                c => new
                {
                    CatalogCategoryId = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.CatalogCategoryId);

            CreateTable(
                "dbo.Catalogs",
                c => new
                {
                    CatalogId = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Description = c.String(nullable: false, maxLength: 1000),
                    EstimatedPrice = c.Int(nullable: false),
                    CatalogCategoryId = c.Int(nullable: false),
                    Picture = c.Binary(),
                })
                .PrimaryKey(t => t.CatalogId);

            CreateTable(
                "dbo.ChatLists",
                c => new
                {
                    ChatId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    AdminId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ChatId);

            CreateTable(
                "dbo.EmployeeRosters",
                c => new
                {
                    EmployeeId = c.Int(nullable: false, identity: true),
                    UserId = c.Int(nullable: false),
                    Department = c.String(nullable: false, maxLength: 50),
                    Designation = c.String(nullable: false, maxLength: 50),
                    Salary = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.EmployeeId);

            CreateTable(
                "dbo.FinancialTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    Amount = c.Int(nullable: false),
                    TransactionDate = c.DateTime(nullable: false),
                    Description = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.TransactionId);

            CreateTable(
                "dbo.InProgressProjects",
                c => new
                {
                    ProjectId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    ReservationId = c.Int(nullable: false),
                    StartDate = c.DateTime(nullable: false),
                    EndDate = c.DateTime(nullable: false),
                    ProjectManagerId = c.Int(nullable: false),
                    EstimatedCost = c.Int(nullable: false),
                    Balance = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ProjectId);

            CreateTable(
                "dbo.InstallmentTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    ProjectId = c.Int(nullable: false),
                    InstallmentNumber = c.Int(nullable: false),
                    InstallmentDue = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TransactionId);

            CreateTable(
                "dbo.MaterialInventories",
                c => new
                {
                    MaterialId = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Quantity = c.Int(nullable: false),
                    Remarks = c.String(maxLength: 50),
                    CriticalLimit = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.MaterialId);

            CreateTable(
                "dbo.MaterialTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    MaterialId = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    VendorId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TransactionId);

            CreateTable(
                "dbo.Messages",
                c => new
                {
                    ChatId = c.Int(nullable: false, identity: true),
                    MessageContent = c.String(nullable: false),
                    TimeStamp = c.DateTime(nullable: false),
                    SenderId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ChatId);

            CreateTable(
                "dbo.Notifications",
                c => new
                {
                    NotificationId = c.Int(nullable: false, identity: true),
                    UserId = c.Int(nullable: false),
                    Content = c.String(nullable: false, maxLength: 100),
                    Type = c.String(nullable: false, maxLength: 50),
                    IsRead = c.Boolean(nullable: false),
                    RedirectUrl = c.String(nullable: false, maxLength: 200),
                })
                .PrimaryKey(t => t.NotificationId);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    VendorId = c.Int(nullable: false),
                    AdminId = c.Int(nullable: false),
                    FinancialTransactionId = c.Int(nullable: false),
                    IsComplete = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.OrderId);

            CreateTable(
                "dbo.Reservations",
                c => new
                {
                    ReservationId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    ProjectId = c.Int(nullable: false),
                    ReservationDate = c.DateTime(nullable: false),
                    Status = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ReservationId);

            CreateTable(
                "dbo.ReservationTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    ReservationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TransactionId);

            CreateTable(
                "dbo.SalaryTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    EmployeeId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TransactionId);

            AddColumn("dbo.Admins", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Vendors", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Vendors", "CompanyName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Admins", "FirstName");
            DropColumn("dbo.Admins", "LastName");
            DropColumn("dbo.Admins", "Email");
            DropColumn("dbo.Admins", "PhoneNumber");
            DropColumn("dbo.Admins", "Address");
            DropColumn("dbo.Admins", "ProfilePicture");
            DropColumn("dbo.Clients", "FirstName");
            DropColumn("dbo.Clients", "LastName");
            DropColumn("dbo.Clients", "Email");
            DropColumn("dbo.Clients", "PhoneNumber");
            DropColumn("dbo.Clients", "Address");
            DropColumn("dbo.Clients", "ProfilePicture");
            DropColumn("dbo.Vendors", "FirstName");
            DropColumn("dbo.Vendors", "LastName");
            DropColumn("dbo.Vendors", "Email");
            DropColumn("dbo.Vendors", "PhoneNumber");
            DropColumn("dbo.Vendors", "Address");
            DropColumn("dbo.Vendors", "ProfilePicture");
        }

        public override void Down()
        {
            AddColumn("dbo.Vendors", "ProfilePicture", c => c.Binary(nullable: false));
            AddColumn("dbo.Vendors", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Vendors", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Vendors", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Vendors", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Vendors", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "ProfilePicture", c => c.Binary());
            AddColumn("dbo.Clients", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "ProfilePicture", c => c.Binary(nullable: false));
            AddColumn("dbo.Admins", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "FirstName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Vendors", "CompanyName");
            DropColumn("dbo.Vendors", "UserId");
            DropColumn("dbo.Clients", "UserId");
            DropColumn("dbo.Admins", "UserId");
            DropTable("dbo.SalaryTransactions");
            DropTable("dbo.ReservationTransactions");
            DropTable("dbo.Reservations");
            DropTable("dbo.Orders");
            DropTable("dbo.Notifications");
            DropTable("dbo.Messages");
            DropTable("dbo.MaterialTransactions");
            DropTable("dbo.MaterialInventories");
            DropTable("dbo.InstallmentTransactions");
            DropTable("dbo.InProgressProjects");
            DropTable("dbo.FinancialTransactions");
            DropTable("dbo.EmployeeRosters");
            DropTable("dbo.ChatLists");
            DropTable("dbo.Catalogs");
            DropTable("dbo.CatalogCategories");
            DropTable("dbo.Authentications");
            DropTable("dbo.ArchivedProjects");
            DropTable("dbo.Appointments");
        }
    }
}
