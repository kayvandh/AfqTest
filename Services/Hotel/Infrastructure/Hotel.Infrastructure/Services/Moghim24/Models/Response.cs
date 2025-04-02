using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class Response<T>
    {
        [JsonPropertyName("requestid")]
        public string Requestid { get; set; }

        [JsonPropertyName("issuccess")]
        public bool Issuccess { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("errors")]
        public Error Errors { get; set; }
    }
}
