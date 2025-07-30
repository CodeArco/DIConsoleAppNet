using ConsoleApp1.Services;

namespace ConsoleApp1
{
    public class Core
    {
        // Get the service database instance through dependency injection
        private IServiceDatabase _serviceDatabase;
        public Core(IServiceDatabase serviceDatabase)
        {
            _serviceDatabase = serviceDatabase;
        }
        // Methods from core
        public void Method1()
        {
            Console.WriteLine("Core.Method1: " + _serviceDatabase.GetData());
        }
        public void Method2()
        {
            Console.WriteLine("Core.Method2: " + _serviceDatabase.GetData());
        }
    }
}
