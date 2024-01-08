namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                {
                    AdminId = c.Int(nullable: false, identity: true),
                    AuthId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.AdminId)
                .ForeignKey("dbo.Authentications", t => t.AuthId, cascadeDelete: true)
                .Index(t => t.AuthId);

            CreateTable(
                "dbo.Authentications",
                c => new
                {
                    AuthId = c.Int(nullable: false, identity: true),
                    UserName = c.String(),
                    Password = c.String(),
                    FirstName = c.String(),
                    LastName = c.String(),
                    EmailAddress = c.String(),
                    PhoneNumber = c.String(),
                    Address = c.String(),
                    ProfilePicture = c.Binary(),
                    Verified = c.Boolean(nullable: false),
                    Banned = c.Boolean(nullable: false),
                    Role = c.String(),
                })
                .PrimaryKey(t => t.AuthId);

            CreateTable(
                "dbo.EmployeeRosters",
                c => new
                {
                    EmployeeId = c.Int(nullable: false, identity: true),
                    AuthId = c.Int(nullable: false),
                    Department = c.String(),
                    Designation = c.String(),
                    Salary = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Authentications", t => t.AuthId, cascadeDelete: true)
                .Index(t => t.AuthId);

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
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeRosters", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.EmployeeId);

            CreateTable(
                "dbo.Clients",
                c => new
                {
                    ClientId = c.Int(nullable: false, identity: true),
                    AuthId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ClientId);

            CreateTable(
                "dbo.ArchivedProjects",
                c => new
                {
                    ProjectId = c.Int(nullable: false),
                    ClientId = c.Int(nullable: false),
                    CompletionDate = c.DateTime(nullable: false),
                    Review = c.String(),
                    Rating = c.Int(nullable: false),
                    Revenue = c.Int(nullable: false),
                    Picture = c.Binary(),
                })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.InProgressProjects", t => t.ProjectId)
                .Index(t => t.ProjectId)
                .Index(t => t.ClientId);

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
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .Index(t => t.ReservationId);

            CreateTable(
                "dbo.ChatLists",
                c => new
                {
                    ChatId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    EmployeeId = c.Int(nullable: false),
                    ProjectId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ChatId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeRosters", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.InProgressProjects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.EmployeeId)
                .Index(t => t.ProjectId);

            CreateTable(
                "dbo.InstallmentTransactions",
                c => new
                {
                    InstallmentTransactionId = c.Int(nullable: false, identity: true),
                    TransactionId = c.Int(nullable: false),
                    ProjectId = c.Int(nullable: false),
                    InstallmentNumber = c.Int(nullable: false),
                    InstallmentDue = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.InstallmentTransactionId)
                .ForeignKey("dbo.FinancialTransactions", t => t.TransactionId, cascadeDelete: true)
                .ForeignKey("dbo.InProgressProjects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.ProjectId);

            CreateTable(
                "dbo.FinancialTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    Amount = c.Int(nullable: false),
                    TransactionDate = c.DateTime(nullable: false),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.TransactionId);

            CreateTable(
                "dbo.MaterialTransactions",
                c => new
                {
                    MaterialTransactionId = c.Int(nullable: false, identity: true),
                    TransactionId = c.Int(nullable: false),
                    MaterialId = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    VendorId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.MaterialTransactionId)
                .ForeignKey("dbo.FinancialTransactions", t => t.TransactionId, cascadeDelete: true)
                .ForeignKey("dbo.MaterialInventories", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.Vendors", t => t.VendorId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.MaterialId)
                .Index(t => t.VendorId);

            CreateTable(
                "dbo.MaterialInventories",
                c => new
                {
                    MaterialId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Quantity = c.Int(nullable: false),
                    Remarks = c.String(),
                    CriticalLimit = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.MaterialId);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    VendorId = c.Int(nullable: false),
                    MaterialTransactionId = c.Int(nullable: false),
                    IsComplete = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.MaterialTransactions", t => t.MaterialTransactionId, cascadeDelete: true)
                .Index(t => t.MaterialTransactionId);

            CreateTable(
                "dbo.Vendors",
                c => new
                {
                    VendorId = c.Int(nullable: false, identity: true),
                    AuthId = c.Int(nullable: false),
                    CompanyName = c.String(),
                })
                .PrimaryKey(t => t.VendorId)
                .ForeignKey("dbo.Authentications", t => t.AuthId, cascadeDelete: true)
                .Index(t => t.AuthId);

            CreateTable(
                "dbo.ReservationTransactions",
                c => new
                {
                    ReservationTransactionId = c.Int(nullable: false, identity: true),
                    FinancialTransactionId = c.Int(nullable: false),
                    ReservationId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ReservationTransactionId)
                .ForeignKey("dbo.FinancialTransactions", t => t.FinancialTransactionId, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .Index(t => t.FinancialTransactionId)
                .Index(t => t.ReservationId);

            CreateTable(
                "dbo.Reservations",
                c => new
                {
                    ReservationId = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    ReservationDate = c.DateTime(nullable: false),
                    Status = c.String(),
                })
                .PrimaryKey(t => t.ReservationId);

            CreateTable(
                "dbo.SalaryTransactions",
                c => new
                {
                    TransactionId = c.Int(nullable: false, identity: true),
                    EmployeeId = c.Int(nullable: false),
                    FinancialTransaction_TransactionId = c.Int(),
                })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.EmployeeRosters", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.FinancialTransactions", t => t.FinancialTransaction_TransactionId)
                .Index(t => t.EmployeeId)
                .Index(t => t.FinancialTransaction_TransactionId);

            CreateTable(
                "dbo.Messages",
                c => new
                {
                    ChatId = c.Int(nullable: false, identity: true),
                    MessageContent = c.String(),
                    TimeStamp = c.DateTime(nullable: false),
                    SenderId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ChatId)
                .ForeignKey("dbo.Authentications", t => t.SenderId, cascadeDelete: true)
                .Index(t => t.SenderId);

            CreateTable(
                "dbo.Notifications",
                c => new
                {
                    NotificationId = c.Int(nullable: false, identity: true),
                    ReceiverId = c.Int(nullable: false),
                    Content = c.String(),
                    Type = c.String(),
                    IsRead = c.Boolean(nullable: false),
                    RedirectUrl = c.String(),
                })
                .PrimaryKey(t => t.NotificationId)
                .ForeignKey("dbo.Authentications", t => t.ReceiverId, cascadeDelete: true)
                .Index(t => t.ReceiverId);

            CreateTable(
                "dbo.CatalogCategories",
                c => new
                {
                    CatalogCategoryId = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(),
                })
                .PrimaryKey(t => t.CatalogCategoryId);

            CreateTable(
                "dbo.Catalogs",
                c => new
                {
                    CatalogId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    EstimatedPrice = c.Int(nullable: false),
                    CatalogCategoryId = c.Int(nullable: false),
                    Picture = c.Binary(),
                })
                .PrimaryKey(t => t.CatalogId)
                .ForeignKey("dbo.CatalogCategories", t => t.CatalogCategoryId, cascadeDelete: true)
                .Index(t => t.CatalogCategoryId);

            CreateTable(
                "dbo.Tokens",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TokenKey = c.String(),
                    CreatedAt = c.DateTime(nullable: false),
                    DeletedAt = c.DateTime(),
                    UserId = c.String(),
                    ExpiresAt = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Catalogs", "CatalogCategoryId", "dbo.CatalogCategories");
            DropForeignKey("dbo.Admins", "AuthId", "dbo.Authentications");
            DropForeignKey("dbo.Notifications", "ReceiverId", "dbo.Authentications");
            DropForeignKey("dbo.Messages", "SenderId", "dbo.Authentications");
            DropForeignKey("dbo.EmployeeRosters", "AuthId", "dbo.Authentications");
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters");
            DropForeignKey("dbo.Appointments", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ArchivedProjects", "ProjectId", "dbo.InProgressProjects");
            DropForeignKey("dbo.InProgressProjects", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.InstallmentTransactions", "ProjectId", "dbo.InProgressProjects");
            DropForeignKey("dbo.InstallmentTransactions", "TransactionId", "dbo.FinancialTransactions");
            DropForeignKey("dbo.SalaryTransactions", "FinancialTransaction_TransactionId", "dbo.FinancialTransactions");
            DropForeignKey("dbo.SalaryTransactions", "EmployeeId", "dbo.EmployeeRosters");
            DropForeignKey("dbo.ReservationTransactions", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.ReservationTransactions", "FinancialTransactionId", "dbo.FinancialTransactions");
            DropForeignKey("dbo.MaterialTransactions", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Vendors", "AuthId", "dbo.Authentications");
            DropForeignKey("dbo.Orders", "MaterialTransactionId", "dbo.MaterialTransactions");
            DropForeignKey("dbo.MaterialTransactions", "MaterialId", "dbo.MaterialInventories");
            DropForeignKey("dbo.MaterialTransactions", "TransactionId", "dbo.FinancialTransactions");
            DropForeignKey("dbo.ChatLists", "ProjectId", "dbo.InProgressProjects");
            DropForeignKey("dbo.ChatLists", "EmployeeId", "dbo.EmployeeRosters");
            DropForeignKey("dbo.ChatLists", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ArchivedProjects", "ClientId", "dbo.Clients");
            DropIndex("dbo.Catalogs", new[] { "CatalogCategoryId" });
            DropIndex("dbo.Notifications", new[] { "ReceiverId" });
            DropIndex("dbo.Messages", new[] { "SenderId" });
            DropIndex("dbo.SalaryTransactions", new[] { "FinancialTransaction_TransactionId" });
            DropIndex("dbo.SalaryTransactions", new[] { "EmployeeId" });
            DropIndex("dbo.ReservationTransactions", new[] { "ReservationId" });
            DropIndex("dbo.ReservationTransactions", new[] { "FinancialTransactionId" });
            DropIndex("dbo.Vendors", new[] { "AuthId" });
            DropIndex("dbo.Orders", new[] { "MaterialTransactionId" });
            DropIndex("dbo.MaterialTransactions", new[] { "VendorId" });
            DropIndex("dbo.MaterialTransactions", new[] { "MaterialId" });
            DropIndex("dbo.MaterialTransactions", new[] { "TransactionId" });
            DropIndex("dbo.InstallmentTransactions", new[] { "ProjectId" });
            DropIndex("dbo.InstallmentTransactions", new[] { "TransactionId" });
            DropIndex("dbo.ChatLists", new[] { "ProjectId" });
            DropIndex("dbo.ChatLists", new[] { "EmployeeId" });
            DropIndex("dbo.ChatLists", new[] { "ClientId" });
            DropIndex("dbo.InProgressProjects", new[] { "ReservationId" });
            DropIndex("dbo.ArchivedProjects", new[] { "ClientId" });
            DropIndex("dbo.ArchivedProjects", new[] { "ProjectId" });
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            DropIndex("dbo.Appointments", new[] { "ClientId" });
            DropIndex("dbo.EmployeeRosters", new[] { "AuthId" });
            DropIndex("dbo.Admins", new[] { "AuthId" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Catalogs");
            DropTable("dbo.CatalogCategories");
            DropTable("dbo.Notifications");
            DropTable("dbo.Messages");
            DropTable("dbo.SalaryTransactions");
            DropTable("dbo.Reservations");
            DropTable("dbo.ReservationTransactions");
            DropTable("dbo.Vendors");
            DropTable("dbo.Orders");
            DropTable("dbo.MaterialInventories");
            DropTable("dbo.MaterialTransactions");
            DropTable("dbo.FinancialTransactions");
            DropTable("dbo.InstallmentTransactions");
            DropTable("dbo.ChatLists");
            DropTable("dbo.InProgressProjects");
            DropTable("dbo.ArchivedProjects");
            DropTable("dbo.Clients");
            DropTable("dbo.Appointments");
            DropTable("dbo.EmployeeRosters");
            DropTable("dbo.Authentications");
            DropTable("dbo.Admins");
        }
    }
}
