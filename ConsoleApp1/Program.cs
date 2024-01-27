
using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");


var builder = Host.CreateDefaultBuilder();
var host = builder.ConfigureServices(services =>
{
    services.AddSingleton<ICalculator, BrokenCalculator>();
    services.AddSingleton<Worker>();

}).Build();


var worker = host.Services.GetRequiredService<Worker>();

Console.WriteLine(worker.AddNumbers(5, 6));

Console.ReadLine();

