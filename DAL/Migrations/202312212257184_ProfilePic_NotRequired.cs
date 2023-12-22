namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilePic_NotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "ProfilePicture", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "ProfilePicture", c => c.Binary(nullable: false));
        }
    }
}
