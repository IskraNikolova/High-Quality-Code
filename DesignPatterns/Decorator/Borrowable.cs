namespace Decorator
{
    using System;
    using System.Collections.Generic;

    public class Borrowable : Decorator
    {
        private readonly List<string> borrowers = new List<string>(); 

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorowItem(string name)
        {
            this.borrowers.Add(name);
            this.LibraryItem.CopiesCount--;
        }

        public void ReturnItem(string name)
        {
            this.borrowers.Remove(name);
            this.LibraryItem.CopiesCount++;
        }

        public override void Display()
        {
            base.Display();
            foreach (var borrower in borrowers)
            {
                Console.WriteLine($"borrower {borrower}");
            }
        }
    }
}
