using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class PriceDetail
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("roomPrice")]
        public int RoomPrice { get; set; }

        [JsonPropertyName("roomPricePercentCommission")]
        public int RoomPricePercentCommission { get; set; }

        [JsonPropertyName("netRoomPrice")]
        public int NetRoomPrice { get; set; }

        [JsonPropertyName("servicePrice")]
        public int ServicePrice { get; set; }

        [JsonPropertyName("servicePricePercentCommission")]
        public int ServicePricePercentCommission { get; set; }

        [JsonPropertyName("netServicePrice")]
        public int NetServicePrice { get; set; }

        [JsonPropertyName("lunchPrice")]
        public int LunchPrice { get; set; }

        [JsonPropertyName("dinnerPrice")]
        public int DinnerPrice { get; set; }
    }
}
