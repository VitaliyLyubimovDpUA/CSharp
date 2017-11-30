using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary;
using System.Net.Mail;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = new ConsoleCreator();
            ILogging log = creator.Create();
            log.Verbose("Hello");

            //ILogging fileLogging = new FileLogging("log.txt");
            //FileMessage fMsg =  (FileMessage)fileLogging.Verbose("New message");

            //MailAddress from = new MailAddress("vitaha.lyubimov@gmail.com", "Виталий Любимов");
            //MailAddress to = new MailAddress("lubimov@itstep.org");
            //ILogging emailLogging = new EmailLogging(from, to, "Тема сообщения", "k8r8zybnmxae");
            //EmailMessage emailMessage = (EmailMessage)emailLogging.Verbose("Текст сообщения");

            Console.ReadLine();
        }
    }
}
