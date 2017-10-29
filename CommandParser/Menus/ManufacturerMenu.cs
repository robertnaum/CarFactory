using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandParser.Commands;
using EasyConsole;

namespace CommandParser.Commands
{
    class ManufacturerMenu : MenuPage
    {
        public ManufacturerMenu(Program program)
            : base("Manufacturer Menu", program,
                new Option("New CarBody manufacturer", () => program.NavigateTo<NewCarBodyManufacturer>()),
                new Option("New Engine manufacturer", () => program.NavigateTo<NewEngineManufacturer>()),
                new Option("New Brake manufacturer", () => program.NavigateTo<NewBrakeManufacturer>()),
                new Option("New Tire Manufacturer", () => program.NavigateTo<NewTireManufacturer>())

                  )
        {
            
        }
    }
}
