﻿using System;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary
{
    public class Logger : ILogger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender { get; set; }

        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }

        public void Log(string msg, ReportLevel level)
        {
            var date = DateTime.Now;
            this.Appender.Append(msg, level, date);
        }
    }
}
