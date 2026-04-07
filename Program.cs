using ConsoleSlots.App;
using ConsoleSlots.Facades;
using ConsoleSlots.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace ConsoleSlots
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var host = Host.CreateDefaultBuilder(args)
           .ConfigureServices((context, services) =>
           {
               // Main once instansiated services
               services.AddSingleton<GameLogicFacade>();


               services.AddSingleton<RandomizerService>();
               services.AddSingleton<PatternService>();
               services.AddSingleton<SymbolService>();
               services.AddSingleton<ScoreService>();


               //Simulation
               services.AddTransient<Simulation>();
           })
           .Build();

            var sim = host.Services.GetRequiredService<Simulation>();
           await  sim.Run();
        }
    }
}
