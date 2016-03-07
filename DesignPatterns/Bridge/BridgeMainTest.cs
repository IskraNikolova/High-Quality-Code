namespace Bridge
{
    using Bridge.AppendersModels;
    using Bridge.FormattersModels;

    public class BridgeMainTest
    {
        public static void Main()
        {
            var simpleFormatter = new SimpleFormatter();

            var appender = new FileAppender();

            appender.Formatter = simpleFormatter;
            appender.Append("Hello!");
        }
    }
}
