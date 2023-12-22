namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ContextDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ContextDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //for (int i = 0; i < 10; i++)
            //{
            //    context.Clients.AddOrUpdate(new Models.Client
            //    {
            //        FirstName =  i+" "+ Guid.NewGuid().ToString().Substring(0, 15),
            //        LastName = Guid.NewGuid().ToString().Substring(0, 15),
            //        Address = Guid.NewGuid().ToString().Substring(0, 15),
            //        Email = Guid.NewGuid().ToString().Substring(0, 15),
            //        PhoneNumber = Guid.NewGuid().ToString().Substring (0, 15),
            //    });
            //}
        }
    }
}
