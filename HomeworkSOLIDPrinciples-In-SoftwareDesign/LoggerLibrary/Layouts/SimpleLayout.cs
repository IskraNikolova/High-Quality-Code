namespace LoggerLibrary.Layouts
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            return $"{date} - {level} - {msg}";
        }
    }
}
