using EasyConsole;

namespace CommandParser.Commands
{
    internal class NewEngineManufacturer : Page
    {
        public NewEngineManufacturer(Program program)
            : base("NewEngineManufacturer", program)
        {            
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("new Engine manufacturer created");

            Input.ReadString(Globals.MAIN_MENU_PROMPT);
            Program.NavigateHome();
        }
    }
}