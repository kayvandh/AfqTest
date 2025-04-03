using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class TransferToHotel
    {
        [JsonPropertyName("flightNumber")]
        public string FlightNumber { get; set; }

        [JsonPropertyName("flightTime")]
        public string FlightTime { get; set; }
    }
}
