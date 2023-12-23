namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                {
                    AdminId = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 50),
                    LastName = c.String(nullable: false, maxLength: 50),
                    Email = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 50),
                    ProfilePicture = c.Binary(nullable: false),
                })
                .PrimaryKey(t => t.AdminId);

            CreateTable(
                "dbo.Clients",
                c => new
                {
                    ClientId = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 50),
                    LastName = c.String(nullable: false, maxLength: 50),
                    Email = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 50),
                    ProfilePicture = c.Binary(nullable: false),
                })
                .PrimaryKey(t => t.ClientId);

            CreateTable(
                "dbo.Vendors",
                c => new
                {
                    VendorId = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 50),
                    LastName = c.String(nullable: false, maxLength: 50),
                    Email = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 50),
                    ProfilePicture = c.Binary(nullable: false),
                })
                .PrimaryKey(t => t.VendorId);
        }

        public override void Down()
        {
            DropTable("dbo.Vendors");
            DropTable("dbo.Clients");
            DropTable("dbo.Admins");
        }
    }
}