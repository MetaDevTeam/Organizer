using Organizer.Data;
using Organizer.Enumerations;
using Organizer.Input;
using Organizer.ScreenElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.ScreenControllers
{
    public class EditBoxController : ScreenController
    {
        public EditBoxController(ScreenElement root, KeyboardInput parser, OrganizerEntities context)
            : base(root, parser, context)
        {
        }

        public string BeginParse()
        {
            bool active = true;
            while (active)
            {
                this.Print();
                var command = this.parser.Listen();
                switch (command)
                {
                    case Command.Back:
                        active = false;
                        break;
                }
            }

            return ((EditBox)this.root).Content;
        }
    }
}
