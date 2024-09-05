using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_NET_5
{
    public class Program
    {
        #region External Resources
        // create folder wwwroot
        // its icon should change to blue globe automatically
        // when you add any external library, libman.json will be created
        #endregion

        // The Console Application
        // Entry Point for the CLR
        public static void Main(string[] args)
        {
            // Calling CreatingHostBuilder Function
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // CreateHostBuilder function will use the data from Class Startup
                    webBuilder.UseStartup<Startup>();
                });
    }
}
