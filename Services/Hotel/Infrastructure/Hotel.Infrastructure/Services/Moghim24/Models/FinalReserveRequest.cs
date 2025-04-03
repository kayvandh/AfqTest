using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class FinalReserveRequest
    {
        [JsonPropertyName("data")]
        public List<FinalReserve> Data { get; set; }
    }
}
