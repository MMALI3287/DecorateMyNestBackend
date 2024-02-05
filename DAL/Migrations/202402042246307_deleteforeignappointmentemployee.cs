namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class deleteforeignappointmentemployee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters");
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            AlterColumn("dbo.Appointments", "EmployeeId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Appointments", "EmployeeId", c => c.Int());
            CreateIndex("dbo.Appointments", "EmployeeId");
            AddForeignKey("dbo.Appointments", "EmployeeId", "dbo.EmployeeRosters", "EmployeeId");
        }
    }
}
