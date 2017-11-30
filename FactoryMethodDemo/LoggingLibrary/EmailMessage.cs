using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class EmailMessage: IMessage
    {
        public MailMessage Msg { get; set; }
        public MailAddress From { get; set; }
        public MailAddress To { get; set; }
        public string Message { get; set; }
        public LevelMsg Level { get; set; }
        public int SourceLineNumber { get; set; }
        public string SouceFilePath { get; set; }
    }
}
