namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "DeletedAt", c => c.DateTime());
        }

        public override void Down()
        {
            DropColumn("dbo.Tokens", "DeletedAt");
        }
    }
}
