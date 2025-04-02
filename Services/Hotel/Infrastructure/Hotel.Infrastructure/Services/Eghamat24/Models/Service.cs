using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class Service
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("conditions")]
        public Conditions Conditions { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
