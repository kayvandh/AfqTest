using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class ServiceData
    {
        [JsonPropertyName("extraService")]
        public int ExtraService { get; set; }

        [JsonPropertyName("lunch")]
        public int Lunch { get; set; }

        [JsonPropertyName("dinner")]
        public int Dinner { get; set; }
    }
}
