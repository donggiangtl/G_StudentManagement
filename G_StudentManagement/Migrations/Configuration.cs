namespace G_StudentManagement.Migrations
{
    using G_StudentManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<G_StudentManagement.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(G_StudentManagement.Models.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Classes.AddOrUpdate(
            c => c.ClassName,
            new Class { ClassName = "Class A" },
            new Class { ClassName = "Class B" }
            );
        }
    }
}
