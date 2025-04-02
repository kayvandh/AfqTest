using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class PropertyImage
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("caption")]
        public object Caption { get; set; }

        [JsonPropertyName("room_type_id")]
        public object RoomTypeId { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
