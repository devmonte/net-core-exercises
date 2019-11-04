using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _12_LibraryCRUD.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _12_LibraryCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var dataSeeder = (ISeedDataService)scope.ServiceProvider.GetRequiredService<ISeedDataService>();
                    dataSeeder.SeedData();
                }
                catch (Exception)
                {
                    //todo add logging
                    throw;
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
