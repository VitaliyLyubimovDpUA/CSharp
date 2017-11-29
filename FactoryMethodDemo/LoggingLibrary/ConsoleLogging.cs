﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.IO;

namespace LoggingLibrary
{
    public class ConsoleLogging : ILogging
    {
        private string template = "";
        public ConsoleLogging()
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
            return new ConsoleMessage
            {
                Level = lvl,
                Message = msg,
                SouceFilePath = sourceFilePath,
                SourceLineNumber = sourceLineNumber
            };
        }

        public IMessage Verbose(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        => SendMessage(msg, LevelMsg.Verbose, sourceFilePath, sourceLineNumber);

        public IMessage Info(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        => SendMessage(msg, LevelMsg.Info, sourceFilePath, sourceLineNumber);

        public IMessage Warning(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        => SendMessage(msg, LevelMsg.Warning, sourceFilePath, sourceLineNumber);

        public IMessage Debug(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        => SendMessage(msg, LevelMsg.Debug, sourceFilePath, sourceLineNumber);

        public IMessage Error(string msg, [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        => SendMessage(msg, LevelMsg.Error, sourceFilePath, sourceLineNumber);
    }
}
