using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class PropertyDetailResult
    {
        [JsonPropertyName("property")]
        public Property Property { get; set; }
    }
}
