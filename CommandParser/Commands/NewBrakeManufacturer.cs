using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace CommandParser.Commands
{
    public class NewBrakeManufacturer : Page
    {
        public NewBrakeManufacturer(Program program)
            : base("NewBrakeManufacturer", program)
        {
            
        }

        public override void Display()
        {
            base.Display();
            Output.WriteLine("new Brake manufacturer created");

            Input.ReadString(Globals.MAIN_MENU_PROMPT);
            Program.NavigateHome();
        }
    }
}
