using CatFacts.Application;
using CatFacts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CatFacts;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddTransient<ICatFactService, CatFactService>();
        services.AddTransient<ICatFileService, CatFileService>();
        services.AddHttpClient<ICatFactService, CatFactService>();
        
        var serviceProvider = services.BuildServiceProvider();
        
        var catApp = new CatApp(
            serviceProvider.GetRequiredService<ICatFactService>(),
            serviceProvider.GetRequiredService<ICatFileService>()
            );
        try
        {
            catApp.RunAsync().GetAwaiter().GetResult();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while running the application: {ex.Message}");
        } 
    }
}