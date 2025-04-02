using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class RoomType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_ar")]
        public string NameAr { get; set; }

        [JsonPropertyName("name_en")]
        public string NameEn { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        [JsonPropertyName("extra_capacity")]
        public int ExtraCapacity { get; set; }

        [JsonPropertyName("single_bed_count")]
        public int SingleBedCount { get; set; }

        [JsonPropertyName("double_bed_count")]
        public int DoubleBedCount { get; set; }

        [JsonPropertyName("sofa_bed_count")]
        public int SofaBedCount { get; set; }

        [JsonPropertyName("out_of_service")]
        public int OutOfService { get; set; }

        [JsonPropertyName("accept_child")]
        public bool AcceptChild { get; set; }

        [JsonPropertyName("facilities")]
        public List<Facility> Facilities { get; set; }

        [JsonPropertyName("rate_plans")]
        public List<RatePlan> RatePlans { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("description_ar")]
        public string DescriptionAr { get; set; }

        [JsonPropertyName("description_en")]
        public string DescriptionEn { get; set; }

    }
}
