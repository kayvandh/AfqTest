using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Extenstions
{
    public static class ServiceProviderExtensions
    {
        public static IEnumerable<T> GetRequiredKeyedServices<T>(this IServiceProvider provider, IEnumerable<object> keys)
        {
            var services = new List<T>();
            foreach (var key in keys)
            {
                var service = provider.GetRequiredKeyedService<T>(key);
                if (service != null) services.Add(service);
            }
            return services;
        }
    }
}
