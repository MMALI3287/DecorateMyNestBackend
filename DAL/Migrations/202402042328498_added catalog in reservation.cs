namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addedcataloginreservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "CatalogCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "CatalogId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Reservations", "CatalogId");
            DropColumn("dbo.Reservations", "CatalogCategoryId");
        }
    }
}
