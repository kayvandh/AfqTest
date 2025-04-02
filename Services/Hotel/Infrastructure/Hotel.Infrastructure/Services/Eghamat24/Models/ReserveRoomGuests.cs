using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class ReserveRoomGuest
    {
        [JsonPropertyName("fist_name")]
        public string? FistName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("national_code")]
        public string? NationalCode { get; set; }

        [JsonPropertyName("passport_number")]
        public string? PassportNumber { get; set; }

        [JsonPropertyName("country_id")]
        public int? CountryId { get; set; }

        [JsonPropertyName("city_id")]
        public int? CityId { get; set; }
    }
}
