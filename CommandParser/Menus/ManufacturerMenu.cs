using CommandParser.Commands;
using EasyConsole;

namespace CommandParser.Menus
{
    class ManufacturerMenu : MenuPage
    {
        public ManufacturerMenu(Program program)
            : base("Manufacturer Menu", program,
                new Option("New CarBody manufacturer", () => program.NavigateTo<NewCarBodyManufacturer>()),
                new Option("New Engine manufacturer", () => program.NavigateTo<NewEngineManufacturer>()),
                new Option("New Brake manufacturer", () => program.NavigateTo<NewBrakeManufacturer>()),
                new Option("New Tire Manufacturer", () => program.NavigateTo<NewTireManufacturer>()),
                new Option("New Front Seat Manufacturer", () => program.NavigateTo<NewTireManufacturer>())

                  )
        {
            
        }
    }
}
