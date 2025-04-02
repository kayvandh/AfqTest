using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class PropertyRule
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_ar")]
        public string NameAr { get; set; }

        [JsonPropertyName("name_en")]
        public string NameEn { get; set; }

        [JsonPropertyName("rule_id")]
        public int RuleId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("conditions")]
        public Conditions Conditions { get; set; }

        [JsonPropertyName("room_type_id")]
        public int RoomTypeId { get; set; }

        [JsonPropertyName("rate_plan_id")]
        public int RatePlanId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("description_ar")]
        public string DescriptionAr { get; set; }

        [JsonPropertyName("description_en")]
        public string DescriptionEn { get; set; }
    }
}
