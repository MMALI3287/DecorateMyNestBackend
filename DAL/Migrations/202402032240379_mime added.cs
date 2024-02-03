namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class mimeadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authentications", "MimeType", c => c.String());
            AddColumn("dbo.ArchivedProjects", "MimeType", c => c.String());
            AddColumn("dbo.Catalogs", "MimeType", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Catalogs", "MimeType");
            DropColumn("dbo.ArchivedProjects", "MimeType");
            DropColumn("dbo.Authentications", "MimeType");
        }
    }
}
