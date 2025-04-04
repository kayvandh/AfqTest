
namespace Hotel.Application.Common
{
    public class KeyedServiceTracker
    {
        private readonly List<ServiceTracker> _serviceTracker = new List<ServiceTracker> ();    

        public void AddServices(int providerId, string serviceKey)
        {
            if (!_serviceTracker.Any(p => p.ProviderId == providerId))
                _serviceTracker.Add(new ServiceTracker(providerId, serviceKey));
        }
        public IReadOnlyList<ServiceTracker> GetServiceTrackers() => _serviceTracker.AsReadOnly();
        public ServiceTracker? GetService(int providerId) => _serviceTracker.FirstOrDefault(p => p.ProviderId == providerId);
    }
    public class ServiceTracker
    {
        public ServiceTracker(int providerId, string serviceKey)
        {
            ProviderId = providerId;
            ServiceKey = serviceKey;
        }

        public int ProviderId { get; set; }
        public string ServiceKey { get; set; }
    }
}
