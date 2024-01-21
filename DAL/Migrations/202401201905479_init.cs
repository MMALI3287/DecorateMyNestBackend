namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tokens", "DeletedAt");
            DropColumn("dbo.Tokens", "Role");
        }

        public override void Down()
        {
            AddColumn("dbo.Tokens", "Role", c => c.String());
            AddColumn("dbo.Tokens", "DeletedAt", c => c.DateTime());
        }
    }
}
