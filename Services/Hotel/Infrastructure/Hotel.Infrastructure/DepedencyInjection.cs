using Framework.HttpClientHelper;
using Hotel.Application.Common;
using Hotel.Application.Common.Services;
using Hotel.Infrastructure.Services;
using Hotel.Infrastructure.Services.Eghamat24;
using Hotel.Infrastructure.Services.Eghamat24.Models;
using Hotel.Infrastructure.Services.Moghim24;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hotel.Infrastructure
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IHttpClientHelper,HttpClientHelper>();
            foreach (var serviceInfo in ServiceInformation.ServiceInfos)
            {
                services.AddHttpClient(serviceInfo.Title, client =>
                {
                    client.BaseAddress = new Uri(serviceInfo.BaseAddress);
                    client.Timeout = TimeSpan.FromSeconds(50);
                }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                });
            }

            var tracker = new KeyedServiceTracker();
            services.AddSingleton(tracker);

            void RegisterKeyedService<TService, TImplementation>(string key)
                where TService : class
                where TImplementation : class, TService
            {
                services.AddKeyedTransient<TService, TImplementation>(key);                
                tracker.AddKey(key);
            }


            //Add all implemented service here

            RegisterKeyedService<IHotelService, Moghim24HotelService>(Infrastructure.Services.ServiceInformation.Moghim24Service);
            RegisterKeyedService<IHotelService, Eghamat24HotelService>(Infrastructure.Services.ServiceInformation.Eghamat24Service);


            return services;
        }



    }
}
