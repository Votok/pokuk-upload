using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.WindowsAzure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using pokuk_common;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace pokuk_upload
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureServices((hostContext, services) =>
            {
               services.AddHostedService<Worker>();
            });
    }
}
