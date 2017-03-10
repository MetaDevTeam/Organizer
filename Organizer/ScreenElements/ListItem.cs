namespace Organizer.ScreenElements
{
    using System;

    public class ListItem : Label
    {
        // Can be modified to contain reference to Entity data
        public ListItem(int x, int y, int w, string content)
            : base(x, y, w, content)
        {
        }
    }
}
