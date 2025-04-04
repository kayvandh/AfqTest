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
        public Int64 RoomPrice { get; set; }

        [JsonPropertyName("roomPricePercentCommission")]
        public Int64 RoomPricePercentCommission { get; set; }

        [JsonPropertyName("netRoomPrice")]
        public Int64 NetRoomPrice { get; set; }

        [JsonPropertyName("servicePrice")]
        public Int64 ServicePrice { get; set; }

        [JsonPropertyName("servicePricePercentCommission")]
        public Int64 ServicePricePercentCommission { get; set; }

        [JsonPropertyName("netServicePrice")]
        public Int64 NetServicePrice { get; set; }

        [JsonPropertyName("lunchPrice")]
        public Int64 LunchPrice { get; set; }

        [JsonPropertyName("dinnerPrice")]
        public Int64 DinnerPrice { get; set; }
    }
}
