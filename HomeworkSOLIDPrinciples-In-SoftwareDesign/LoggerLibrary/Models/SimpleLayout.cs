using System;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary.Models
{
    public class SimpleLayout : ILayout
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            return $"{date} - {level} - {msg}";
        }
    }
}
