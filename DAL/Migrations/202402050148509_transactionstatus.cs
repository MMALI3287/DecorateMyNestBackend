namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class transactionstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FinancialTransactions", "Status", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.FinancialTransactions", "Status");
        }
    }
}
