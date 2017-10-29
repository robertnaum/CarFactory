using EasyConsole;

namespace CommandParser.Commands
{
    public class NewEngineManufacturer : Page
    {
        public NewEngineManufacturer(Program program)
            : base("NewEngineManufacturer", program)
        {            
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("new Engine manufacturer created");
            Program.NavigateHome();
        }
    }
}