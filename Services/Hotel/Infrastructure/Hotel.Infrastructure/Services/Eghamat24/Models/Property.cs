using System.Text.Json.Serialization;


namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class Property
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("star")]
        public string Star { get; set; }

        [JsonPropertyName("name_ar")]
        public string NameAr { get; set; }

        [JsonPropertyName("name_en")]
        public string NameEn { get; set; }

        [JsonPropertyName("grade")]
        public string Grade { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("province_id")]
        public int ProvinceId { get; set; }

        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("address_ar")]
        public string AddressAr { get; set; }

        [JsonPropertyName("address_en")]
        public string AddressEn { get; set; }

        [JsonPropertyName("rooms_count")]
        public int RoomsCount { get; set; }

        [JsonPropertyName("facilities")]
        public List<Facility> Facilities { get; set; }

        [JsonPropertyName("room_types")]
        public List<RoomType> RoomTypes { get; set; }

        [JsonPropertyName("rate_plans")]
        public List<RatePlan> RatePlans { get; set; }

        [JsonPropertyName("images")]
        public List<PropertyImage> Images { get; set; }

        [JsonPropertyName("rules")]
        public List<PropertyRule> Rules { get; set; }

        [JsonPropertyName("services")]
        public List<Service> Services { get; set; }


        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("description_ar")]
        public string DescriptionAr { get; set; }

        [JsonPropertyName("description_en")]
        public string DescriptionEn { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }
    }
}
