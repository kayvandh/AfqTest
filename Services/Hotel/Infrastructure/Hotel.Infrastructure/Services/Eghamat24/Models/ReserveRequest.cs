using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class ReserveRequest
    {
        [JsonPropertyName("property_id")]
        public int PropertyId { get; set; }

        [JsonPropertyName("check_in")]
        public DateOnly CheckIn { get; set; }

        [JsonPropertyName("check_out")]
        public DateOnly CheckOut { get; set; }

        [JsonPropertyName("booker_first_name")]
        public string BookerFirstName { get; set; }
        
        [JsonPropertyName("booker_last_name")]
        public string BookerLastName { get; set; }


        [JsonPropertyName("booker_phone")]
        public string BookerPhone { get; set; }

        [JsonPropertyName("booker_email")]
        public string? BookerEmail { get; set; }

        [JsonPropertyName("agency_confirmation_code")]
        public string? AgencyConfirmationCode { get; set; }

        [JsonPropertyName("agent")]
        public string Agent { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rooms")]
        public List<ReserveRoom> Rooms { get; set; }
    }
}
