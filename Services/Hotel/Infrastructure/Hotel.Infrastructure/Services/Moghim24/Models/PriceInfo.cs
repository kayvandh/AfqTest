using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class PricesInfo
    {
        [JsonPropertyName("details")]
        public List<PriceDetail> Details { get; set; }
    }
}
