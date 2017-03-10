namespace Organizer.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OrganizerEntities : DbContext
    {
        public OrganizerEntities()
            : base("name=OrganizerEntities")
        {
        }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}