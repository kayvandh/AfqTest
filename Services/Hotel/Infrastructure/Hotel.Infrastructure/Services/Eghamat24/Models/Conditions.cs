using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class Conditions
    {
        [JsonPropertyName("check_in")]
        public string CheckIn { get; set; }

        [JsonPropertyName("check_out")]
        public string CheckOut { get; set; }

        [JsonPropertyName("max_infant_age")]
        public string MaxInfantAge { get; set; }

        [JsonPropertyName("max_child_age")]
        public string MaxChildAge { get; set; }

        [JsonPropertyName("check_in_hours_ago")]
        public int CheckInHoursAgo { get; set; }
    }
}
