using Hotel.Infrastructure.Services.Moghim24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class Suggestion
    {
        [JsonPropertyName("property_id")]
        public int PropertyId { get; set; }

        [JsonPropertyName("property_name")]
        public string PropertyName { get; set; }

        [JsonPropertyName("property_name_ar")]
        public string PropertyNameAr { get; set; }

        [JsonPropertyName("property_name_en")]
        public object PropertyNameEn { get; set; }

        [JsonPropertyName("rooms")]
        public List<Room> Rooms { get; set; }
    }
}
