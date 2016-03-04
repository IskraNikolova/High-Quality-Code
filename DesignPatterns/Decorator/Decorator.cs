namespace Decorator
{
    public abstract class Decorator : LibraryItem
    {
        protected Decorator(LibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        public LibraryItem LibraryItem { get; set; }

        public override void Display()
        {
            this.LibraryItem.Display();
        }
    }
}