namespace Organizer.ScreenControllers
{
    using Data;
    using Enumerations;
    using Input;
    using Models.Contacts;
    using ScreenElements;
    using ScreenElements.Composite;
    using System.Linq;

    public class ContactsController : ScreenController
    {
        public ContactsController(KeyboardInput parser, OrganizerEntities context)
            : base(parser, context)
        {
            var listBox = new ScrollList(1, 1, 11, 9);
            foreach (var person in context.People.ToList())
            {
                listBox.AddItem(person.FirstName + " " + person.LastName, person.Id);
            }

            this.root = new ContactsList(0, 0, listBox);
        }

        private void OpenDetails(Person Contact)
        {
            var details = new ContactDetailsController(parser, context, Contact);
            details.BeginParse();
        }

        public void BeginParse()
        {
            while (true)
            {
                int refId = ((ContactsList)this.root).GetSelected();
                var current = context.People.Find(refId);

                string[] details = new string[]
                {
                    current.FirstName,
                    current.LastName,
                    //$"Email:      {current.Emails.FirstOrDefault().Text}",
                };
                ((ContactsList)this.root).SetDetails(details);

                this.Print();
                var command = this.parser.Listen();
                switch (command)
                {
                    case Command.MoveUp:
                        ((ContactsList)root).MoveUp();
                        break;
                    case Command.MoveDown:
                        ((ContactsList)root).MoveDown();
                        break;
                    case Command.Execute:
                        this.OpenDetails(current);
                        break;
                    case Command.Back:
                        return;
                }
            }
        }
    }
}
