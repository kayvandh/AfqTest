using Framework.Mapping.Interfaces;

namespace Hotel.Application.Common.Models
{
    public class City : IOneWayReverseMap<Domain.City>
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string TitleFa { get; set; }
        public string TitleEn { get; set; }
        public string IataCode { get; set; }
        public  List<ProviderCity> ProviderCities { get; set; }
    }

    public class ProviderCity : IOneWayReverseMap<Domain.ProviderCity>
    {
        public int ProviderId { get; set; }
        public string Code { get; set; }

    }
}
