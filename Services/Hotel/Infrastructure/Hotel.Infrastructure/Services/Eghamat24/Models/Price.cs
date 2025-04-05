using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class Price
    {
        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("inventory")]
        public int Inventory { get; set; }

        [JsonPropertyName("rack_rate")]
        public int RackRate { get; set; }

        [JsonPropertyName("daily_rate")]
        public int DailyRate { get; set; }

        [JsonPropertyName("grs_rate")]
        public int? GrsRate { get; set; }

        [JsonPropertyName("baby_cot_rack_rate")]
        public int? BabyCotRackRate { get; set; }

        [JsonPropertyName("baby_cot_daily_rate")]
        public int? BabyCotDailyRate { get; set; }

        [JsonPropertyName("baby_cot_grs_rate")]
        public int? BabyCotGrsRate { get; set; }

        [JsonPropertyName("extend_bed_rack_rate")]
        public int?  ExtendBedRackRate { get; set; }

        [JsonPropertyName("extend_bed_daily_rate")]
        public int? ExtendBedDailyRate { get; set; }

        [JsonPropertyName("extend_bed_grs_rate")]
        public int? ExtendBedGrsRate { get; set; }

        [JsonPropertyName("reservation_state")]
        public string ReservationState { get; set; }

        [JsonPropertyName("min_stay")]
        public int? MinStay { get; set; }

        [JsonPropertyName("max_stay")]
        public int? MaxStay { get; set; }

        [JsonPropertyName("close_to_arrival")]
        public bool CloseToArrival { get; set; }

        [JsonPropertyName("close_to_departure")]
        public bool CloseToDeparture { get; set; }

        [JsonPropertyName("closed")]
        public bool Closed { get; set; }
    }
}
