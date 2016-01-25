using System;
using Logger.Appenders;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout formatter)
            : base(formatter)
        {
        }

        public override void Append(string message, ReportLevel level, DateTime date)
        {
            string output = this.Formatter.Format(message, level, date);
            Console.WriteLine(output);
        }
    }
}
