namespace Organizer.ScreenControllers
{
    using Data;
    using Enumerations;
    using Input;
    using ScreenElements;

    public class ContactDetailsController : ScreenController
    {
        public ContactDetailsController(ScreenElement root, KeyboardInput parser, OrganizerEntities context)
            : base(root, parser, context)
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
