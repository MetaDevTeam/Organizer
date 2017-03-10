namespace Organizer.Data.Migrations
{
    using Models.Contacts;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Organizer.Data.OrganizerEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Organizer.Data.OrganizerEntities";
        }

        protected override void Seed(Organizer.Data.OrganizerEntities context)
        {
            var guy1 = new Person()
            {
                FirstName = "Ivan",
                LastName = "Ivanov"
            };

            var guy2 = new Person()
            {
                FirstName = "Pesho",
                LastName = "Petrov"
            };

            context.People.AddOrUpdate(p => new { p.FirstName, p.LastName }, guy1, guy2);
        }
    }
}
