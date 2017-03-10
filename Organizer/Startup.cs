namespace Organizer
{
    using Data;
    using ScreenElements;
    using System;

    class Startup
    {
        static void Main()
        {
            // Setup screen
            Console.WindowWidth = 50;
            Console.WindowHeight = 17;
            Console.BufferWidth = 50;
            Console.BufferHeight = 17;

            // Setup element style
            ScreenElement.DefaultBGColor = ConsoleColor.Blue;
            ScreenElement.DefaultFGColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Write("Initializing...");

            // Establish DB connection
            var context = new OrganizerEntities();
            context.Database.Initialize(true);

            // Hide cursor after initialization is completed
            Console.CursorVisible = false;
            var app = new Organizer(context);
            app.Start();

            Console.Clear();
            Console.CursorVisible = true;
            Console.Write("Closing connection...");
            Console.WriteLine();
        }
    }
}
