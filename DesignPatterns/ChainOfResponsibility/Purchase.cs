namespace ChainOfResponsibility
{
    public class Purchase
    {
        public Purchase(int number, double amount)
        {
            Number = number;
            Amount = amount;
        }

        public int Number { get; set; }

        public double Amount { get; set; }
    }
}
