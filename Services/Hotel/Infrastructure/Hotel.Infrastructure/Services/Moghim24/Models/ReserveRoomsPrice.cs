using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class ReserveRoomsPrice
    {
        [JsonPropertyName("totalRoomsPrice")]
        public int TotalRoomsPrice { get; set; }

        [JsonPropertyName("totalRoomsPriceCommission")]
        public int TotalRoomsPriceCommission { get; set; }

        [JsonPropertyName("totalNetRoomsPrice")]
        public int TotalNetRoomsPrice { get; set; }

        [JsonPropertyName("totalServicesPrice")]
        public int TotalServicesPrice { get; set; }

        [JsonPropertyName("totalServicesPriceCommission")]
        public int TotalServicesPriceCommission { get; set; }

        [JsonPropertyName("totalNetServicesPrice")]
        public int TotalNetServicesPrice { get; set; }

        [JsonPropertyName("totalLunchPrice")]
        public int TotalLunchPrice { get; set; }

        [JsonPropertyName("totalDinnerPrice")]
        public int TotalDinnerPrice { get; set; }

        [JsonPropertyName("totalReservePrice")]
        public int TotalReservePrice { get; set; }
    }
}
