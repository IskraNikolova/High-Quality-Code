namespace Bridge.FormattersModels
{
    public class SimpleFormatter : Formatter
    {
        public override string Format(string message)
        {
            return "Message:" + message;
        }
    }
}