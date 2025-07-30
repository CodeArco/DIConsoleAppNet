using ConsoleApp1;
using ConsoleApp1.Services;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        // Register services
        var services = new ServiceCollection();
        services.AddSingleton<IServiceDatabase, ServiceDatabase2>();
        services.AddSingleton<Core>();
        var serviceProvider = services.BuildServiceProvider();

        // Call core methods
        Core core = serviceProvider.GetService<Core>();
        core.Method1();
        core.Method2();
    }
}