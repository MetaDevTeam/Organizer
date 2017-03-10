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
            context.People.AddOrUpdate(p => new { p.FirstName, p.LastName },
                new Person()
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov"
                },
                new Person()
                {
                    FirstName = "Pesho",
                    LastName = "Petrov"
                },
                new Person()
                {
                    FirstName = "Georgi",
                    LastName = "Georgiev"
                },
                new Person()
                {
                    FirstName = "Grigor",
                    LastName = "Grigorov"
                },
                new Person()
                {
                    FirstName = "Petkan",
                    LastName = "Petkanov"
                },
                new Person()
                {
                    FirstName = "Katya",
                    LastName = "Kadieva"
                },
                new Person()
                {
                    FirstName = "Asen",
                    LastName = "Asenov"
                },
                new Person()
                {
                    FirstName = "Kosta",
                    LastName = "Kostov"
                },
                new Person()
                {
                    FirstName = "Anton",
                    LastName = "Antonov"
                },
                new Person()
                {
                    FirstName = "Iliya",
                    LastName = "Iliev"
                },
                new Person()
                {
                    FirstName = "Maria",
                    LastName = "Ivanova"
                },
                new Person()
                {
                    FirstName = "Stanka",
                    LastName = "Krasimirova"
                },
                new Person()
                {
                    FirstName = "Ognyqn",
                    LastName = "Ognyanov"
                });
        }
    }
}
