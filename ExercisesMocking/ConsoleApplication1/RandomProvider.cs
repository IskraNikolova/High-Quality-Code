using System;

namespace ConsoleApplication1
{
    public class RandomProvider: IRandomProvider
    {
        private Random random;

        public RandomProvider()
        {
            this.random = new Random();
        }

        public int GetRandomNumber()
        {
            return random.Next();
        }
    }
}
