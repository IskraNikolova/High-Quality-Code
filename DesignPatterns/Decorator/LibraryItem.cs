namespace Decorator
{
    public abstract class LibraryItem
    {
        public int CopiesCount { get; set; }

        public abstract void Display();
    }
}
