using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Moghim24.Models
{
    public class Passenger
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("passKind")]
        public string PassKind { get; set; }

        [JsonPropertyName("melliCode")]
        public string MelliCode { get; set; }

        [JsonPropertyName("passport")]
        public string Passport { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }

        [JsonPropertyName("passportExpireDate")]
        public string PassportExpireDate { get; set; }

        [JsonPropertyName("nationality")]
        public int Nationality { get; set; }

        [JsonPropertyName("ordinal")]
        public int Ordinal { get; set; }

        [JsonPropertyName("bed")]
        public bool Bed { get; set; }
    }

}
