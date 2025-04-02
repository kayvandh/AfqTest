using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class ReserveRoom
    {
        [JsonPropertyName("room_type_id")]
        public int RoomTypeId { get; set; }

        [JsonPropertyName("rate_plan_id")]
        public int RatePlanId { get; set; }

        [JsonPropertyName("reserve_room_code")]
        public int ReserveRoomCode { get; set; }


        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("adult_count")]
        public int AdultCount { get; set; }

        [JsonPropertyName("children")]
        public List<Children> Children { get; set; }

        [JsonPropertyName("guest_first_name")]
        public string GuestFirstName { get; set; }

        [JsonPropertyName("guest_last_name")]
        public string GuestLastName { get; set; }

        [JsonPropertyName("guest_phone")]
        public string? GuestPhone { get; set; }

        [JsonPropertyName("guest_email")]
        public string? GuestEmail { get; set; }

        [JsonPropertyName("guest_national_code")]
        public string? GuestNationalCode { get; set; }

        [JsonPropertyName("guest_passport_number")]
        public string? GuestPassportNumber { get; set; }

        [JsonPropertyName("guest_country_id")]
        public int? GuestCountryId { get; set; }

        [JsonPropertyName("guest_city_id")]
        public int? GuestCityId { get; set; }

        [JsonPropertyName("guests")]
        public List<ReserveRoomGuest> Guests { get; set; }

    }
}
