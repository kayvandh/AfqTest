using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class ReserveResult
    {
        [JsonPropertyName("sessionId")]
        public string SessionId { get; set; }

        [JsonPropertyName("rooms")]
        public List<ReserveRoom> Rooms { get; set; }

        [JsonPropertyName("totalRoomsPrice")]
        public ReserveRoomsPrice TotalRoomsPrice { get; set; }
    }
}
