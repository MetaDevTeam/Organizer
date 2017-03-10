namespace Organizer.ScreenControllers
{
    using Enumerations;
    using Input;
    using ScreenElements;
    using ScreenElements.Composite;

    public class ContactsController : ScreenController
    {
        public ContactsController(KeyboardInput parser)
            : base(parser)
        {
            var listBox = new ScrollList(1, 1, 11, 9);
            listBox.AddItem("Pesho");
            listBox.AddItem("Gosho");
            listBox.AddItem("Ivan");
            listBox.AddItem("Dragan");
            listBox.AddItem("Petkan");
            listBox.AddItem("Georgi");
            listBox.AddItem("Atanas");
            listBox.AddItem("Ivaylo");
            listBox.AddItem("Vladimir");
            listBox.AddItem("Stoyan");
            listBox.AddItem("Grigor");
            listBox.AddItem("Kalin");

            this.root = listBox;
        }

        private void OpenDetails(ScreenElement target)
        {
            var details = new ContactDetailsController(new TextBox(5, 5, 15, 3, "contact details"), parser);
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
                        ((ScrollList)root).MoveUp();
                        break;
                    case Command.MoveDown:
                        ((ScrollList)root).MoveDown();
                        break;
                    case Command.Execute:
                        this.OpenDetails(((ScrollList)this.root).GetSelected());
                        break;
                    case Command.Back:
                        return;
                }
            }
        }
    }
}
