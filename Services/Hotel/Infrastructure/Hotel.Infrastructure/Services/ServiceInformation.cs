using Hotel.Application.Common.Services;
using Hotel.Infrastructure.Services.Eghamat24;
using Hotel.Infrastructure.Services.Moghim24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services
{
    public static class ServiceInformation
    {
        public static List<ServiceData> ServiceInfos = new List<ServiceData>()
        {
            new ServiceData(1,"MOGHIM24", "https://hotel.moghim24.services",typeof(Moghim24HotelService)),
            new ServiceData(2,"EGHMAT24", "https://api.grschannel.com",typeof(Eghamat24HotelService))
        };

        public static ServiceData? GetServiceInfo(int providerId) => ServiceInfos.FirstOrDefault(p => p.ProviderId == providerId);
    }

    public class ServiceData
    {
        public ServiceData(int providerId, string serviceKeytle, string baseAddress, Type implementedService)
        {
            ServiceKey = serviceKeytle;
            BaseAddress = baseAddress;
            ProviderId = providerId;
            ImplementedService = implementedService;
        }

        public int ProviderId { get; set; }
        public string ServiceKey { get; set; }
        public string BaseAddress { get; set; }
        public Type ImplementedService { get; set; }
    }
}
