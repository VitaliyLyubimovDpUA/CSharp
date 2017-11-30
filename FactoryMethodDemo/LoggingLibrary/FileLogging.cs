using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    //public class FileLogging : ILogging
    //{
    //    private string outputFilePath;
    //    private string template = "";

    //    public FileLogging(string outputFilePath)
    //    {
    //        template = ConfigurationManager.AppSettings["writeTemplate"];
    //        this.outputFilePath = outputFilePath;
    //    }
    //    private IMessage SendMessage(string msg, LevelMsg lvl, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
    //    {
    //        string text = template.Replace("%T", lvl.ToString())
    //                              .Replace("%D", DateTime.Now.ToShortDateString())
    //                              .Replace("%t", DateTime.Now.ToShortTimeString())
    //                              .Replace("%F", sourceFilePath)
    //                              .Replace("%l", sourceLineNumber.ToString())
    //                              .Replace("%m", msg + "\r\n");
    //        lock (this)
    //        {
    //            File.AppendAllText(outputFilePath, text);
    //        }
    //        return new FileMessage
    //        {
    //            Level = lvl,
    //            Message = msg,
    //            OutputFilePath = outputFilePath,
    //            SouceFilePath = sourceFilePath,
    //            SourceLineNumber = sourceLineNumber
    //        };
    //    }
    //    public IMessage Debug(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
    //    => SendMessage(msg, LevelMsg.Debug, sourceFilePath, sourceLineNumber);

    //    public IMessage Error(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
    //    => SendMessage(msg, LevelMsg.Error, sourceFilePath, sourceLineNumber);

    //    public IMessage Info(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
    //    => SendMessage(msg, LevelMsg.Info, sourceFilePath, sourceLineNumber);

    //    public IMessage Verbose(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
    //    => SendMessage(msg, LevelMsg.Verbose, sourceFilePath, sourceLineNumber);

    //    public IMessage Warning(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
    //    => SendMessage(msg, LevelMsg.Warning, sourceFilePath, sourceLineNumber);
    //}
}
