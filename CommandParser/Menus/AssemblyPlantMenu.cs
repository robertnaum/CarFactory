using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandParser.Commands;
using EasyConsole;

namespace CommandParser.Menus
{
    class AssemblyPlantMenu : MenuPage
    {
        public AssemblyPlantMenu(Program program) :
            base("Assembly Plant Menu", program, 
                new Option("New Assembly Plant", () => program.NavigateTo<NewAssemblyPlant>()))
        {
            
        }
    }
}
