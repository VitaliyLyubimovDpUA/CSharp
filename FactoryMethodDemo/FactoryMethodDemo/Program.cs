using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogging consLog = new ConsoleLogging(new ConsoleMessage());
            consLog.Verbose();
        }
    }
}
