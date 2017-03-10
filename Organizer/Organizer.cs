namespace Organizer
{
    using Data;
    using Input;
    using ScreenControllers;

    public class Organizer
    {
        private OrganizerEntities context;
        private KeyboardInput kbInput;
        private HomeScreenController homeScreen;

        public Organizer(OrganizerEntities context)
        {
            this.context = context;
            this.kbInput = new KeyboardInput();
            this.homeScreen = new HomeScreenController(this.kbInput, context);
        }

        public void Start()
        {
            this.homeScreen.BeginParse();

            // Clean up, if necessary
        }
    }
}
