using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keypath.API.MigrationSupport;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Keypath.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MJS Note: MigrateData() would not be called like this for a production app
            //          I just want it to create the database if Steve want to run this.
            //          Steve will need to adjust the connection string in appsettings.json (likely)

            CreateHostBuilder(args).Build().MigrateDatabase().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
