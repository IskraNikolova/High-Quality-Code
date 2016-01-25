using System;

namespace LoggerLibrary.Interfaces
{
    public interface ILayout
    {
        string Format(string msg, ReportLevel level, DateTime date);
    }
}