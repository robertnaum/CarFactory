using System;
//using CommandParser.Commands;
using EasyConsole;

namespace CommandParser.Menus
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
