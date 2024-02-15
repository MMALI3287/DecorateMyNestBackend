namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class rewriteinstrans : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.InstallmentTransactions", "InstallmentDue");
        }

        public override void Down()
        {
            AddColumn("dbo.InstallmentTransactions", "InstallmentDue", c => c.Int(nullable: false));
        }
    }
}
