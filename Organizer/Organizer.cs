namespace Organizer
{
    using Input;
    using ScreenControllers;

    public class Organizer
    {
        private KeyboardInput kbInput;
        private HomeScreenController homeScreen;

        public Organizer()
        {
            this.kbInput = new KeyboardInput();
            this.homeScreen = new HomeScreenController(this.kbInput);
        }

        public void Start()
        {
            this.homeScreen.BeginParse();

            // Clean up, if necessary
        }
    }
}
