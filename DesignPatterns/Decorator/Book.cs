using System;

namespace Decorator
{
    public class Book : LibraryItem
    {
        private readonly string author;
        private readonly string title;

        public Book(string author, string title, int countOfCopies)
        {
            this.author = author;
            this.title = title;
            this.CopiesCount = countOfCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook-------------");
            Console.WriteLine($"Author {this.author}");
            Console.WriteLine($"Title {this.title}");
            Console.WriteLine($"# Copies {this.CopiesCount}\n");
        }
    }
}
