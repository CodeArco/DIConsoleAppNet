using ConsoleApp1.Services;

namespace ConsoleApp1
{
    public class Core
    {
        public void Method1()
        {
            IServiceDatabase service = new ServiceDatabase1();
            Console.WriteLine("Core.Method1: " + service.GetData());
        }
        public void Method2()
        {
            IServiceDatabase service = new ServiceDatabase1();
            Console.WriteLine("Core.Method2: " + service.GetData());
        }
    }
}