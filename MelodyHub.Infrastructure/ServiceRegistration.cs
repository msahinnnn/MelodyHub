using MelodyHub.Application.Abstractions.Storage;
using MelodyHub.Infrastructure.Services.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IImageStorageService, ImageStorageService>();
            serviceCollection.AddSingleton<IAudioStorageService, AudioStorageService>();
        }
    }
}
