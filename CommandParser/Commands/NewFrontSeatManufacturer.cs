using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace CommandParser.Commands
{
    internal class NewFrontSeatManufacturer : Page
    {

        public NewFrontSeatManufacturer(Program program)
            :base("NewFrontSeatManufacturer", program)
        {
            
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("new FrontSeat manufacturer created");

            Input.ReadString(Globals.MAIN_MENU_PROMPT);
            Program.NavigateHome();
        }

    }
}
