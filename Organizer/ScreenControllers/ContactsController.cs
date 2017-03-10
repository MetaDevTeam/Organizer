namespace Organizer.ScreenControllers
{
    using Data;
    using Enumerations;
    using Input;
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
                listBox.AddItem(person.FirstName + " " + person.LastName);
            }

            this.root = new ContactsList(0, 0, listBox);
        }

        private void OpenDetails(ScreenElement target)
        {
            var details = new ContactDetailsController(new TextBox(5, 5, 15, 3, "contact details"), parser, context);
            details.BeginParse();
        }

        public void BeginParse()
        {
            while (true)
            {
                //System.Console.Clear();
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
                        //this.OpenDetails(((ContactsList)this.root).GetSelected());
                        break;
                    case Command.Back:
                        return;
                }
            }
        }
    }
}
