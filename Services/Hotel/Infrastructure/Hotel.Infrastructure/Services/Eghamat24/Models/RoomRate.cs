using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class RoomRate
    {
        [JsonPropertyName("property_id")]
        public int PropertyId { get; set; }

        [JsonPropertyName("room_type_id")]
        public int RoomTypeId { get; set; }

        [JsonPropertyName("room_type_name")]
        public string RoomTypeName { get; set; }

        [JsonPropertyName("rate_plans")]
        public List<RatePlan> RatePlans { get; set; }
    }
}
