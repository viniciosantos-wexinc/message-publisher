using System.Diagnostics.CodeAnalysis;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;

namespace MessageConsumer;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test");
        Console.ReadKey();
        // var builder = Host.CreateApplicationBuilder(args);

        // builder.LoadSettings()
        //        .ConfigureSettings()
        //        .RegisterServices();

        // // builder.Services.AddHostedService<HealthCheckHostedService>();

        // var app = builder.Build();

        // app.Run();
    }
}