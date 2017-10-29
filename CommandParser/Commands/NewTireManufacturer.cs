using EasyConsole;

namespace CommandParser.Menus
{
    internal class NewTireManufacturer : Page
    {
        public NewTireManufacturer(Program program)
            : base("NewTireManufacturer", program)
        {
            
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("new Tire manufacturer created");

            Input.ReadString(Globals.MAIN_MENU_PROMPT);
            Program.NavigateHome();
        }
    }
}