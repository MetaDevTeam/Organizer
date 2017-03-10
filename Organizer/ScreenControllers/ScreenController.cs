namespace Organizer.ScreenControllers
{
    using Input;
    using ScreenElements;

    public abstract class ScreenController
    {
        protected ScreenElement root;
        protected KeyboardInput parser;

        public ScreenController(KeyboardInput parser)
        {
            this.parser = parser;
        }

        public ScreenController(ScreenElement root, KeyboardInput parser)
        {
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
