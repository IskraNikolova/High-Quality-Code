namespace Observer
{
    public class ObserverMainTest
    {
        public static void Main()
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("New investor"));

            ibm.Price = 121.90;
            ibm.Price = 200.00;
        }
    }
}