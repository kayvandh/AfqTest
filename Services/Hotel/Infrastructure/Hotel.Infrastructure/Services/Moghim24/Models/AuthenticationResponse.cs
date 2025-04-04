using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class AuthenticationResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
