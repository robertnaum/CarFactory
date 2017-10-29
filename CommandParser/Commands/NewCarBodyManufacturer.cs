using EasyConsole;

namespace CommandParser.Commands
{
    public class NewCarBodyManufacturer : Page
    {
        public NewCarBodyManufacturer(Program program)
            : base("NewCarBodyManufacturer", program)
        {
            
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("new CarBody manufacturer created");

            Input.ReadString(Globals.MAIN_MENU_PROMPT);
            Program.NavigateHome();
        }
    }
}