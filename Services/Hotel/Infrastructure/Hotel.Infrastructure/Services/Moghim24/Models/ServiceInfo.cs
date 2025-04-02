using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class ServiceInfo
    {
        [JsonPropertyName("transferToHotel")]
        public bool TransferToHotel { get; set; }

        [JsonPropertyName("transferFromHotel")]
        public bool TransferFromHotel { get; set; }

        [JsonPropertyName("breakFast")]
        public bool BreakFast { get; set; }

        [JsonPropertyName("lunch")]
        public bool Lunch { get; set; }

        [JsonPropertyName("dinner")]
        public bool Dinner { get; set; }

        [JsonPropertyName("other")]
        public string Other { get; set; }

        [JsonPropertyName("selectableLunch")]
        public bool SelectableLunch { get; set; }

        [JsonPropertyName("selectableDinner")]
        public bool SelectableDinner { get; set; }
    }
}
