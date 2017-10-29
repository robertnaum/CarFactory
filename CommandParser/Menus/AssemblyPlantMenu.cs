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
