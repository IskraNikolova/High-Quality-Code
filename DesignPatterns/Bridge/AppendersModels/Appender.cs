namespace Bridge.AppendersModels
{
    using Bridge.FormattersModels;

    public abstract class Appender
    {
        public Formatter Formatter { get; set; }

        public abstract void Append(string message);
    }
}
