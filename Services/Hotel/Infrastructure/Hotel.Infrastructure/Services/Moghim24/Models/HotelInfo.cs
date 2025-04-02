using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class HotelInfo
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("hotelFaName")]
        public string HotelFaName { get; set; }

        [JsonPropertyName("moghimCode")]
        public string MoghimCode { get; set; }

        [JsonPropertyName("grade")]
        public int Grade { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("floorNo")]
        public int FloorNo { get; set; }

        [JsonPropertyName("roomNo")]
        public int RoomNo { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("ageChdWithoutBedFree")]
        public string AgeChdWithoutBedFree { get; set; }

        [JsonPropertyName("ageChdWithoutBedHalfPrice")]
        public string AgeChdWithoutBedHalfPrice { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("kindFaName")]
        public string KindFaName { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lng")]
        public double Lng { get; set; }

        [JsonPropertyName("rooms")]
        public List<HotelInfoRoom> Rooms { get; set; }
    }

    public class HotelInfoRoom
    {
        [JsonPropertyName("roomCode")]
        public int RoomCode { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
