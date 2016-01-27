namespace LoggerTest
{
    using LoggerLibrary;
    using LoggerLibrary.Appenders;
    using LoggerLibrary.Interfaces;
    using LoggerLibrary.Layouts;

    public class MainTest
    {
        public static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON");
            logger.Info($"User {"Pesho"} successfully registered.");
        }
    }
}
