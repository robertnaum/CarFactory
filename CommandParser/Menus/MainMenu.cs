using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace CommandParser.Commands
{
    class MainMenu : MenuPage
    {
        public MainMenu(Program program)
            : base("Main Page", program,
                  new Option("Manufacturer", () => program.NavigateTo<ManufacturerMenu>()),
                  new Option("AssemblyPlant", () => program.NavigateTo<AssemblyPlantMenu>()),
                  new Option("Quit the program", () => Environment.Exit(0)))
        {
            
        }

    }
}
