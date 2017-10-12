using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.WindowsAzure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types
using Newtonsoft.Json;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using pokuk_common;
using Microsoft.Extensions.Configuration;

namespace pokuk_upload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");

            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddEnvironmentVariables();

            var configuration = builder.Build();

            var config = new GalleryOptions();
            configuration.Bind(config);

            var provider = new GalleryProvider(config);
            provider.AddNewEventsToAzure();

            Console.WriteLine("Program finished.");
        }
    }
}
