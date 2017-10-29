using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace CommandParser.Commands
{
    class NewCarManufacturer : Page
    {
        public NewCarManufacturer(Program program)
            : base("NewCarManufacturer", program)
        {
            
        }

        public override void Display()
        {
            base.Display();
            Output.WriteLine("new car manufacturer created");

            Input.ReadString("Press [Enter] to go to Main Menu");
            Program.NavigateHome();
        }
    }
}
