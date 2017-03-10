namespace Organizer.ScreenElements.Composite
{
    using System;
    using Utility;

    public class ContactsList : ScreenElement
    {
        private Layout layout;
        private ScrollList contacts;
        private Paragraph details;

        public ContactsList(int x, int y, ScrollList list)
            : base(x, y)
        {
            this.contacts = list;
            this.Init();
            this.details = new Paragraph(12, 1);
            this.details.AddLine("Details pane");
        }

        private void Init()
        {
            this.layout = new Layout(0, 0);
            var matrix = Composer.MakeBoxLayout(49, 16);
            Composer.AddHorizontalLine(matrix, 10, 0, 48);
            Composer.AddVerticalLine(matrix, 10, 0, 10);
            this.layout.SetLayout(Composer.Compose(matrix));
        }

        public void MoveUp()
        {
            this.contacts.MoveUp();
        }

        public void MoveDown()
        {
            this.contacts.MoveDown();
        }

        public override void SetBackgroundColor(ConsoleColor color)
        {
            base.SetBackgroundColor(color);
            this.layout.SetBackgroundColor(color);
            this.contacts.SetBackgroundColor(color);
            this.details.SetBackgroundColor(color);
        }

        public override void SetForegroundColor(ConsoleColor color)
        {
            base.SetForegroundColor(color);
            this.layout.SetForegroundColor(color);
            this.contacts.SetForegroundColor(color);
            this.details.SetForegroundColor(color);
        }

        protected override void Render()
        {
            this.layout.Print();
            this.contacts.Print();
            this.details.Print();
        }
    }
}
