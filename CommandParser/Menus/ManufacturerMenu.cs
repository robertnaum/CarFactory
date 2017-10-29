using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandParser.Commands;
using EasyConsole;

namespace CommandParser.Menus
{
    class ManufacturerMenu : MenuPage
    {
        public ManufacturerMenu(Program program) 
            : base("Manufacturer Menu", program,
                  new Option("New car manufacturer", () => program.NavigateTo<NewCarManufacturer>()))
        {
            
        }
    }
}
