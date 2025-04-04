using Framework.HttpClientHelper;
using Hotel.Application.Common;
using Hotel.Application.Common.Repositories;
using Hotel.Application.Common.Services;
using Hotel.Infrastructure.Persistance.Repositories;
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
                services.AddHttpClient(serviceInfo.ServiceKey, client =>
                {
                    client.BaseAddress = new Uri(serviceInfo.BaseAddress);
                    client.Timeout = TimeSpan.FromSeconds(50);
                }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                });
            }


            // this approach is more felexible

            var serviceTracker = new KeyedServiceTracker();
            services.AddSingleton(serviceTracker);

            foreach (var serviceInfo in ServiceInformation.ServiceInfos)
            {
                services.AddKeyedTransient(typeof(IHotelService), serviceInfo.ServiceKey, serviceInfo.ImplementedService);
                serviceTracker.AddServices(serviceInfo.ProviderId, serviceInfo.ServiceKey);
            }

            // this approach is faster and safer

            //void RegisterKeyedService<TService, TImplementation>(int providerId, string serviceKey)
            //    where TService : class
            //    where TImplementation : class, TService
            //{
            //    services.AddKeyedTransient<TService, TImplementation>(serviceKey);
            //    serviceTracker.AddServices(providerId, serviceKey);
            //}

            ////Add all implemented service here

            //RegisterKeyedService<IHotelService, Moghim24HotelService>(1, Infrastructure.Services.ServiceInformation.Moghim24Service);
            //RegisterKeyedService<IHotelService, Eghamat24HotelService>(2, Infrastructure.Services.ServiceInformation.Eghamat24Service);


            services.AddScoped<ICityRepository, CityRepository>();
            return services;
        }



    }
}
