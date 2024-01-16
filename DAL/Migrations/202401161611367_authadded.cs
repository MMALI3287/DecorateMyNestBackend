namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class authadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "Role", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Tokens", "Role");
        }
    }
}
