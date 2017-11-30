using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    //public class EmailLogging : ILogging
    //{
    //    private string template = "";
    //    MailMessage msg;
    //    string pass;
    //    public EmailLogging(MailAddress from, MailAddress to, string subject, string pass)
    //    {
    //        template = ConfigurationManager.AppSettings["writeTemplate"];
    //        msg = new MailMessage(from, to)
    //        {
    //            Subject = subject,
    //        };
    //        this.pass = pass;
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
    //            this.msg.Body = text;
    //            // адрес smtp-сервера и порт, с которого будем отправлять письмо
    //            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
    //            // логин и пароль
    //            smtp.Credentials = new NetworkCredential(this.msg.From.Address, pass);
    //            smtp.EnableSsl = true;
    //            smtp.Send(this.msg);
    //        }
    //        return new EmailMessage
    //        {
    //            Level = lvl,
    //            Message = text,
    //            SouceFilePath = sourceFilePath,
    //            SourceLineNumber = sourceLineNumber,
    //            From = this.msg.From,
    //            To = this.msg.To.First(),
    //            Msg = this.msg
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
