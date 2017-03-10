namespace Organizer.ScreenControllers
{
    using Data;
    using Input;
    using ScreenElements;

    public abstract class ScreenController
    {
        protected OrganizerEntities context;
        protected ScreenElement root;
        protected KeyboardInput parser;

        public ScreenController(KeyboardInput parser, OrganizerEntities context)
        {
            this.context = context;
            this.parser = parser;
        }

        public ScreenController(ScreenElement root, KeyboardInput parser, OrganizerEntities context)
        {
            this.context = context;
            this.root = root;
            this.parser = parser;
        }

        public void Print()
        {
            System.Console.SetCursorPosition(0, 0);
            this.root.Print();
        }
    }
}
