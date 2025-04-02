using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class LocationInfo
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("cityIataCode")]
        public string CityIataCode { get; set; }

        [JsonPropertyName("cityEnName")]
        public string CityEnName { get; set; }

        [JsonPropertyName("cityFaName")]
        public string CityFaName { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
