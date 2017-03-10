namespace Organizer.ScreenControllers
{
    using Enumerations;
    using Input;
    using ScreenElements;
    using ScreenElements.Composite;
    using Utility;

    public class HomeScreenController : ScreenController
    {
        public HomeScreenController(KeyboardInput parser)
            : base(parser)
        {
            var matrix = Composer.MakeBoxLayout(49, 16);
            Composer.AddHorizontalLine(matrix, 10, 0, 48);
            Composer.AddVerticalLine(matrix, 10, 0, 10);
            var layout = new Layout(0, 0);
            layout.SetLayout(Composer.Compose(matrix));
            this.root = layout;
        }

        public void OpenContactList()
        {
            var contacts = new ContactsController(this.parser);
            contacts.BeginParse();
        }

        public void BeginParse()
        {
            while (true)
            {
                this.Print();
                var command = this.parser.Listen();
                switch (command)
                {
                    //case Command.MoveUp:
                    //    ((ListBox)root).MoveUp();
                    //    break;
                    //case Command.MoveDown:
                    //    ((ListBox)root).MoveDown();
                    //    break;
                    case Command.Execute:
                        this.OpenContactList();
                        break;
                    case Command.Back:
                        return;
                }
            }
        }
    }
}
