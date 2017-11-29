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
            //ILogging logging = new ConsoleLogging();
            //ConsoleMessage consoleMessage = (ConsoleMessage)logging.Warning("Hello");

            //ILogging fileLogging = new FileLogging("log.txt");
            //FileMessage fMsg =  (FileMessage)fileLogging.Verbose("New message");


            Console.ReadLine();
        }
    }
}
