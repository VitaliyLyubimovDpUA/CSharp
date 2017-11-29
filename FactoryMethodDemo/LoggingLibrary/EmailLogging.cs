using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class EmailLogging : ILogging
    {
        private string template = "";
        public EmailLogging()
        {
            template = ConfigurationManager.AppSettings["writeTemplate"];
        }
        private IMessage SendMessage(string msg, LevelMsg lvl, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            string text = template.Replace("%T", lvl.ToString())
                                  .Replace("%D", DateTime.Now.ToShortDateString())
                                  .Replace("%t", DateTime.Now.ToShortTimeString())
                                  .Replace("%F", sourceFilePath)
                                  .Replace("%l", sourceLineNumber.ToString())
                                  .Replace("%m", msg + "\r\n");

            lock (this)
            {
                Console.WriteLine(text);
            }
            return new EmailMessage
            {
                Level = lvl,
                Message = msg,
                SouceFilePath = sourceFilePath,
                SourceLineNumber = sourceLineNumber
            };
        }
        public IMessage Debug(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            throw new NotImplementedException();
        }

        public IMessage Error(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            throw new NotImplementedException();
        }

        public IMessage Info(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            throw new NotImplementedException();
        }

        public IMessage Verbose(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            throw new NotImplementedException();
        }

        public IMessage Warning(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            throw new NotImplementedException();
        }
    }
}
