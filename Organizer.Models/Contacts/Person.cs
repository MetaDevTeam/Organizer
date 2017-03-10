namespace Organizer.Models.Contacts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        public Person()
        {
            this.Emails = new HashSet<Email>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Alias { get; set; }

        public virtual ICollection<Email> Emails { get; set; }
    }
}
