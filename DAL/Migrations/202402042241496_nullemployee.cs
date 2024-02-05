namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class nullemployee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters");
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            AlterColumn("dbo.Appointments", "EmployeeId", c => c.Int());
            CreateIndex("dbo.Appointments", "EmployeeId");
            AddForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters", "EmployeeId");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters");
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            AlterColumn("dbo.Appointments", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "EmployeeId");
            AddForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters", "EmployeeId", cascadeDelete: true);
        }
    }
}
