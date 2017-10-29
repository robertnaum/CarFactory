using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace CommandParser.Commands
{
    public class NewAssemblyPlant : Page
    {
        public NewAssemblyPlant(Program program)
            : base("New Assembly Plant", program)
        {            
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("new assembly plant created");

            Input.ReadString("Press [Enter] to go to Main Menu");
            Program.NavigateHome();
        }
    }
}
