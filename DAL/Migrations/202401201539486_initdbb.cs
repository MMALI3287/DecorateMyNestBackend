namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initdbb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "ExpiresAt", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.Tokens", "ExpiresAt", c => c.DateTime(nullable: false));
        }
    }
}
