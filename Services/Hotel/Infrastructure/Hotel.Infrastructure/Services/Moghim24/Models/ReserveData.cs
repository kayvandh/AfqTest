using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class ReserveData
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("roomId")]
        public string RoomId { get; set; }

        [JsonPropertyName("requestedAvailData")]
        public object RequestedAvailData { get; set; }

        [JsonPropertyName("passengerCount")]
        public int PassengerCount { get; set; }

        [JsonPropertyName("uniqueRequestNumber")]
        public int UniqueRequestNumber { get; set; }

        [JsonPropertyName("serviceData")]
        public ServiceData ServiceData { get; set; }
    }
}
