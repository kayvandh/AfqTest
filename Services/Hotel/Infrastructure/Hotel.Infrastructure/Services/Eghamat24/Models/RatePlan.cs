using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class RatePlan
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("country_id")]
        public int CountryId { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_ar")]
        public object NameAr { get; set; }

        [JsonPropertyName("name_en")]
        public object NameEn { get; set; }

        [JsonPropertyName("meal_type_included")]
        public string MealTypeIncluded { get; set; }

        [JsonPropertyName("board_type")]
        public string BoardType { get; set; }

        [JsonPropertyName("food_board_type")]
        public string FoodBoardType { get; set; }

        [JsonPropertyName("breakfast_rate")]
        public int BreakfastRate { get; set; }

        [JsonPropertyName("half_board_rate")]
        public int HalfBoardRate { get; set; }

        [JsonPropertyName("full_board_rate")]
        public int FullBoardRate { get; set; }

        [JsonPropertyName("cancelable")]
        public bool Cancelable { get; set; }

        [JsonPropertyName("sleeps")]
        public int Sleeps { get; set; }

        [JsonPropertyName("facilities")]
        public List<FacilityDetails> Facilities { get; set; }

        [JsonPropertyName("prices")]
        public List<Price> Prices { get; set; }

        [JsonPropertyName("min_stay")]
        public int MinStay { get; set; }

        [JsonPropertyName("max_stay")]
        public int MaxStay { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("property_id")]
        public int PropertyId { get; set; }

        [JsonPropertyName("agency_id")]
        public int AgencyId { get; set; }

        [JsonPropertyName("duration_hours")]
        public int DurationHours { get; set; }

        [JsonPropertyName("checkout")]
        public int Checkout { get; set; }
    }
}
