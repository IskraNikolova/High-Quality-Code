namespace CommandPattern
{
    public class CommandPatternMainTest
    {
        public static void Main()
        {
            var engine = new Engine();

            engine.Compute('+', 100);
            engine.Compute('-', 50);
            engine.Compute('*', 10);
            engine.Compute('/', 2);

            engine.Undo(4);

            engine.Redo(3);
        }
    }
}
