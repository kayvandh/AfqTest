using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class SugesstionResult
    {
        [JsonPropertyName("suggestions")]
        public List<Suggestion> Suggestions { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
