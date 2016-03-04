namespace Decorator
{
    public class DecoratorTestMain
    {
        public static void Main()
        {
            var book = new Book("Iskra Nikolova", "Nishto", 12);

            var video = new Video("Iskra Nikolova", "Neshto", 22, 99);

            var borrowableVideo = new Borrowable(video);
            borrowableVideo.Display();

            var borrowableVideo1 = new Borrowable(book);           
            borrowableVideo1.Display();
        }
    }
}