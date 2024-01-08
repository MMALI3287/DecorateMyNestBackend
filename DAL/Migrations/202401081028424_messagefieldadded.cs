namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class messagefieldadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ChatListId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Messages", "ChatListId");
        }
    }
}
