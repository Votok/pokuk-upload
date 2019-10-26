using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using pokuk_common;

namespace pokuk_upload
{
    internal class Worker : IHostedService
    {
        private readonly ILogger _logger;
        private readonly GalleryOptions _config;

        public Worker(
            ILogger<Worker> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _config = new GalleryOptions();
            configuration.Bind(_config);
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Program started");

            var provider = new GalleryProvider(_config);
            provider.AddNewEventsToAzure();

            Console.WriteLine("Program finished.");

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}