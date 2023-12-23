namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class controllercreation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "TransactionId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "FinancialTransactionId");
        }

        public override void Down()
        {
            AddColumn("dbo.Orders", "FinancialTransactionId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "TransactionId");
        }
    }
}
