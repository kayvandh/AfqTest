using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class Room
    {
        [JsonPropertyName("roomId")]
        public string RoomId { get; set; }

        [JsonPropertyName("roomIndex")]
        public int RoomIndex { get; set; }

        [JsonPropertyName("roomCode")]
        public int RoomCode { get; set; }

        [JsonPropertyName("roomName")]
        public string RoomName { get; set; }

        [JsonPropertyName("roomCapacity")]
        public int RoomCapacity { get; set; }

        [JsonPropertyName("minimumRoomCount")]
        public int MinimumRoomCount { get; set; }

        [JsonPropertyName("serviceCapacity")]
        public int ServiceCapacity { get; set; }

        [JsonPropertyName("pricesInfo")]
        public PricesInfo PricesInfo { get; set; }

        [JsonPropertyName("serviceInfo")]
        public ServiceInfo ServiceInfo { get; set; }
    }
}
