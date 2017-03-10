namespace Organizer.ScreenControllers
{
    using Enumerations;
    using Input;
    using ScreenElements;

    public class ContactDetailsController : ScreenController
    {
        public ContactDetailsController(ScreenElement root, KeyboardInput parser)
            : base(root, parser)
        {
        }

        public void BeginParse()
        {
            while (true)
            {
                this.Print();
                var command = this.parser.Listen();
                switch (command)
                {
                    case Command.Back:
                        return;
                }
            }
        }
    }
}
