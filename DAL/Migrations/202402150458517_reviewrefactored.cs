namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class reviewrefactored : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ArchivedProjects", "Revenue");
            DropColumn("dbo.ArchivedProjects", "Picture");
            DropColumn("dbo.ArchivedProjects", "MimeType");
        }

        public override void Down()
        {
            AddColumn("dbo.ArchivedProjects", "MimeType", c => c.String());
            AddColumn("dbo.ArchivedProjects", "Picture", c => c.Binary());
            AddColumn("dbo.ArchivedProjects", "Revenue", c => c.Int(nullable: false));
        }
    }
}
