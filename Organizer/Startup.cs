namespace Organizer
{
    using ScreenElements;
    using ScreenElements.Composite;
    using System;
    using Utility;

    class Startup
    {
        static void Main()
        {
            // Setup screen
            Console.WindowWidth = 50;
            Console.WindowHeight = 17;
            Console.BufferWidth = 50;
            Console.BufferHeight = 17;
            Console.CursorVisible = false;

            // Setup element style
            ScreenElement.DefaultBGColor = ConsoleColor.Blue;
            ScreenElement.DefaultFGColor = ConsoleColor.Yellow;

            var app = new Organizer();
            app.Start();
        }
    }
}
