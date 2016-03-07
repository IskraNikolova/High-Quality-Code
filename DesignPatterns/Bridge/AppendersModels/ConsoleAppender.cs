namespace Bridge.AppendersModels
{
    using System;

    public class ConsoleAppender : Appender
    {
        public override void Append(string message)
        {
            Console.WriteLine(this.Formatter.Format(message));
        }
    }
}
