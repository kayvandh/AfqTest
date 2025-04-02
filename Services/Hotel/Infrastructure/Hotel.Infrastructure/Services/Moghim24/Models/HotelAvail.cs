using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class HotelAvail
    {
        [JsonPropertyName("agencyCode")]
        public string AgencyCode { get; set; }

        [JsonPropertyName("agencyName")]
        public string AgencyName { get; set; }

        [JsonPropertyName("moghimCode")]
        public string MoghimCode { get; set; }

        [JsonPropertyName("kindName")]
        public string KindName { get; set; }

        [JsonPropertyName("hotelName")]
        public string HotelName { get; set; }

        [JsonPropertyName("grade")]
        public int Grade { get; set; }

        [JsonPropertyName("minFreeChildAge")]
        public int MinFreeChildAge { get; set; }

        [JsonPropertyName("locationInfo")]
        public LocationInfo LocationInfo { get; set; }

        [JsonPropertyName("rooms")]
        public List<Room> Rooms { get; set; }
    }



  



  



}
