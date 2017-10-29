using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandParser
{
    internal sealed class Runner
    {
        private static void Main(string[] args)
        {
            new CommandParser().Run();

        }
    }
}
