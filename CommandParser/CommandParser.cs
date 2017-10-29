using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandParser.Commands;
using CommandParser.Menus;
using EasyConsole;

namespace CommandParser
{
    class CommandParser : Program
    {
        public CommandParser() : base("Command Parser for CarFactory", true)
        {
            AddPage(new MainMenu(this));
            AddPage(new ManufacturerMenu(this));
            AddPage(new NewBrakeManufacturer(this));
            AddPage(new AssemblyPlantMenu(this));
            AddPage(new NewAssemblyPlant(this));

            SetPage<MainMenu>();
        }
    }
}
