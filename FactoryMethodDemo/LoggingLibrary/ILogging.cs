using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public enum LevelMsg
    {
        Verbose, Warning, Info, Debug, Error
    }
    public interface ILogging
    {
        string OutputTemplate { get; set; }
        void Verbose();
        void Info();
        void Warning();
        void Debug();
        void Error();
    }
}
