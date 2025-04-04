using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class SuggestionRequest
    {
        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        [JsonPropertyName("check_in")]
        public DateOnly CheckInDate { get; set; }

        [JsonPropertyName("check_out")]
        public DateOnly CheckOutDate { get; set; }

        [JsonPropertyName("rooms_count")]
        public int? RoomsCount { get; set; }

        [JsonPropertyName("adults_count")]
        public int AdultCount { get; set; }

        [JsonPropertyName("children")]
        public List<int>? Children { get; set; }

        [JsonPropertyName("property_id")]
        public int? PropertyId { get; set; }


    }
}
