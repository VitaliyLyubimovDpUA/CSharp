using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class FileMessage : IMessage
    {
        public string OutputFilePath { get; set; }
        public string Message { get; set; }
        public LevelMsg Level { get; set; }
        public int SourceLineNumber { get; set; }
        public string SouceFilePath { get; set; }
    }
}
