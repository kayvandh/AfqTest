using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class ReserveRoom
    {
        [JsonPropertyName("reserveId")]
        public string ReserveId { get; set; }

        [JsonPropertyName("roomId")]
        public string RoomId { get; set; }

        [JsonPropertyName("uniqueRequestNumber")]
        public int UniqueRequestNumber { get; set; }

        [JsonPropertyName("agencyCode")]
        public string AgencyCode { get; set; }

        [JsonPropertyName("roomPrice")]
        public int RoomPrice { get; set; }

        [JsonPropertyName("roomPriceCommission")]
        public int RoomPriceCommission { get; set; }

        [JsonPropertyName("netRoomPrice")]
        public int NetRoomPrice { get; set; }

        [JsonPropertyName("servicePrice")]
        public int ServicePrice { get; set; }

        [JsonPropertyName("servicePriceCommission")]
        public int ServicePriceCommission { get; set; }

        [JsonPropertyName("netServicePrice")]
        public int NetServicePrice { get; set; }

        [JsonPropertyName("lunchPrice")]
        public int LunchPrice { get; set; }

        [JsonPropertyName("dinnerPrice")]
        public int DinnerPrice { get; set; }

        [JsonPropertyName("totalReserveRoomPrice")]
        public int TotalReserveRoomPrice { get; set; }
    }
}
