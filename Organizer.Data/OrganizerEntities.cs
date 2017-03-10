namespace Organizer.Data
{
    using Migrations;
    using Models.Contacts;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OrganizerEntities : DbContext
    {
        public OrganizerEntities()
            : base("OrganizerEntities")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrganizerEntities, Configuration>());
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
    }
}