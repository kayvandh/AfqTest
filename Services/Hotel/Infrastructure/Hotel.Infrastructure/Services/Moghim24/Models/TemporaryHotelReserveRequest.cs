using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class TemporaryHotelReserveRequest
    {
        [JsonPropertyName("data")]
        public List<ReserveData> Data { get; set; }

        [JsonPropertyName("reserveIfChange")]
        public bool ReserveIfChange { get; set; }
    }


}
