using System;

namespace Singleton
{
    public class SingletonMainTest
    {
        public static void Main()
        {
            SingletonDemo sD1 = SingletonDemo.Instance;
            SingletonDemo sD2 = SingletonDemo.Instance;

            Console.WriteLine(sD1 == sD2);
        }
    }
}
