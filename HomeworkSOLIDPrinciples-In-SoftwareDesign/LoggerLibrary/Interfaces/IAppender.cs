
using System;

namespace LoggerLibrary.Interfaces
{
    public interface IAppender
    {
        ILayout Formatter { get; set; }

        void Append(string message, ReportLevel level, DateTime date);
    }
}