using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LoggingLibrary
{
    public class ConsoleLogging: ILogging
    {
        private string outFilePath = "";
        private ConsoleMessage msg;
        public string OutputTemplate { get; set; }
        public ConsoleLogging(ConsoleMessage msg)
        {
            OutputTemplate = ConfigurationManager.AppSettings["writeTemplate"];
            outFilePath = ConfigurationManager.AppSettings["outputFilePath"];
            this.msg = msg;
        }
        private void SendMessage(LevelMsg lvl)
        {
            
        }
        public void Verbose()
        {

        }
        public void Info()
        {

        }
        public void Warning()
        {

        }
        public void Debug()
        {

        }
        public void Error()
        {

        }
    }
}
