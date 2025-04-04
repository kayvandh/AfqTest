using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class AuthenticationRequest
    {
        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("md5password")]
        public string Md5Password { get; set; }
    }
}
