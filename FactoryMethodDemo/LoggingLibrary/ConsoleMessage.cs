using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class ConsoleMessage: IMessage
    {
        public string Message { get; set; }
        public LevelMsg Level { get; set; }
        public int SourceLineNumber { get; set; }
        public string SouceFilePath { get; set; }
    }
}
