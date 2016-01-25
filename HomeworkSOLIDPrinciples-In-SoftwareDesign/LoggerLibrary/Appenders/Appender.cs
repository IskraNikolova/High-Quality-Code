using System;
using LoggerLibrary;
using LoggerLibrary.Interfaces;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        private ILayout formatter;

        protected Appender(ILayout formatter)
        {
            this.Formatter = formatter;
        }

        public ILayout Formatter
        {
            get { return this.formatter; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "Formatter cannot be null");
                }

                this.formatter = value;
            }
        }

        public abstract void Append(string message, ReportLevel level, DateTime date);
    }
}
