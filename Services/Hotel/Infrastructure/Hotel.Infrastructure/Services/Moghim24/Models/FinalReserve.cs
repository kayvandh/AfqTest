using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class FinalReserve
    {
        [JsonPropertyName("reserveId")]
        public string ReserveId { get; set; }

        [JsonPropertyName("mark")]
        public string Mark { get; set; }

        [JsonPropertyName("transferToHotel")]
        public TransferToHotel TransferToHotel { get; set; }

        [JsonPropertyName("transferFromHotel")]
        public TransferFromHotel TransferFromHotel { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("passengers")]
        public List<Passenger> Passengers { get; set; }
    }
}
