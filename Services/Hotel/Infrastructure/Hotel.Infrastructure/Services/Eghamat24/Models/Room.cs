using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class Room
    {
        [JsonPropertyName("room_type_id")]
        public int RoomTypeId { get; set; }

        [JsonPropertyName("room_type")]
        public string RoomType { get; set; }

        [JsonPropertyName("room_type_name")]
        public string RoomTypeName { get; set; }

        [JsonPropertyName("room_type_name_ar")]
        public string RoomTypeNameAr { get; set; }

        [JsonPropertyName("room_type_name_en")]
        public string RoomTypeNameEn { get; set; }

        [JsonPropertyName("room_type_capacity")]
        public int RoomTypeCapacity { get; set; }

        [JsonPropertyName("room_type_extra_capacity")]
        public int RoomTypeExtraCapacity { get; set; }

        [JsonPropertyName("rate_plans")]
        public List<RatePlan> RatePlans { get; set; }
    }
}
