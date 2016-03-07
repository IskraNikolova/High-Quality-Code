using Observer.Interfaces;

namespace Observer
{
    using System;

    public class Investor : IInvestor
    {
        private readonly string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public Stock Stock { get; set; }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", this.name, stock.Symbol, stock.Price);
        }
    }
}
