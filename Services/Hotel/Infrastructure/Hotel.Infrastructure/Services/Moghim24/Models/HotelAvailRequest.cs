using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class HotelAvailRequest
    {
        [JsonPropertyName("agencyCode")]
        public List<string>? AgencyCode { get; set; }

        [JsonPropertyName("moghimCode")]
        public List<string>? MoghimCode { get; set; }

        [JsonPropertyName("country")]
        public List<string> Country { get; set; }

        [JsonPropertyName("city")]
        public List<string> City { get; set; }

        [JsonPropertyName("roomCapacity")]
        public List<int> RoomCapacity { get; set; }

        [JsonPropertyName("dateFormat")]
        public string DateFormat { get; set; }

        [JsonPropertyName("checkInDate")]
        public string CheckInDate { get; set; }

        [JsonPropertyName("checkOutDate")]
        public string CheckOutDate { get; set; }

        [JsonPropertyName("shamsiCheckInDate")]
        public string ShamsiCheckInDate { get; set; }

        [JsonPropertyName("shamsiCheckOutDate")]
        public string ShamsiCheckOutDate { get; set; }

        [JsonPropertyName("extraService")]
        public List<int> ExtraService { get; set; }

        [JsonPropertyName("moreCaps")]
        public bool MoreCaps { get; set; }
    }
}
