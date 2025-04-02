using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class HotelInfoRequest
    {
        [JsonPropertyName("moghimCode")]
        public List<string> MoghimCode { get; set; }

        [JsonPropertyName("cityiataCode")]
        public List<string> CityIataCode { get; set; }

        [JsonPropertyName("country")]
        public List<string> Country { get; set; }

        [JsonPropertyName("grade")]
        public List<int> Grade { get; set; }

        [JsonPropertyName("agencyCode")]
        public List<string> AgencyCode { get; set; }
    }
}
