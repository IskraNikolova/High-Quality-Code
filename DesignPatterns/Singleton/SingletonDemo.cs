namespace Singleton
{
    //1
    //public sealed class SingletonDemo
    //{
    //    private static readonly SingletonDemo instance = new SingletonDemo();
    //
    //    private SingletonDemo() { }
    // 
    //    public static SingletonDemo Instance
    //    {
    //        get {
    //                return instance; 
    //            }
    //    }
    //}

    //2
    public class SingletonDemo
    {
        public static readonly SingletonDemo Instance = new SingletonDemo();

        private SingletonDemo() { }
    }
}