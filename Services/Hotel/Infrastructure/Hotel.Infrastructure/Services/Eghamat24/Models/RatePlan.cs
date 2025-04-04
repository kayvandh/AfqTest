﻿using System;
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
        public int? CountryId { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_ar")]
        public string NameAr { get; set; }

        [JsonPropertyName("name_en")]
        public string NameEn { get; set; }

        [JsonPropertyName("meal_type_included")]
        public string MealTypeIncluded { get; set; }

        [JsonPropertyName("board_type")]
        public string BoardType { get; set; }

        [JsonPropertyName("food_board_type")]
        public string FoodBoardType { get; set; }

        [JsonPropertyName("breakfast_rate")]
        public int? BreakfastRate { get; set; }

        [JsonPropertyName("half_board_rate")]
        public int? HalfBoardRate { get; set; }

        [JsonPropertyName("full_board_rate")]
        public int? FullBoardRate { get; set; }

        [JsonPropertyName("cancelable")]
        public int Cancelable { get; set; }

        [JsonPropertyName("sleeps")]
        public int? Sleeps { get; set; }

        [JsonPropertyName("facilities")]
        public List<FacilityDetails> Facilities { get; set; }

        [JsonPropertyName("prices")]
        public List<Price> Prices { get; set; }

        [JsonIgnore]
        public double TotalPrice => Prices.Sum(p=>p.DailyRate);
        [JsonIgnore]
        public double DailyPrice => Prices.Average(p => p.DailyRate);
    }
}
