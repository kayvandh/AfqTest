using Hotel.Infrastructure.Services.Moghim24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24.Models
{
    public class ReserveDetails
    {
        [JsonPropertyName("property_id")]
        public int PropertyId { get; set; }

        [JsonPropertyName("check_in")]
        public DateOnly CheckIn { get; set; }

        [JsonPropertyName("check_out")]
        public DateOnly CheckOut { get; set; }

        [JsonPropertyName("booker_first_name")]
        public string BookerFirstName { get; set; }

        [JsonPropertyName("booker_last_name")]
        public string BookerLastName { get; set; }

        [JsonPropertyName("booker_phone")]
        public string BookerPhone { get; set; }

        [JsonPropertyName("booker_email")]
        public string? BookerEmail { get; set; }

        public string State { get; set; }
        public string Status { get; set; }
        public string ConfirmationCode { get; set; }
        public string PropertyConfirmationCode { get; set; }
        public string AgencyConfirmationCode { get; set; }
        public int Discount { get; set; }
        public Int64 TotalPrice { get; set; }
        public Int64 TotalSalesPrice { get; set; }
        public Int64 TotalDailyPrice { get; set; }
        public Int64 TotalCancellationFee { get; set; }
        public Int64 TotalModificationFee { get; set; }
        public List<PriceDetail> PriceDetails { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CancelDate { get; set; }
        public DateTime DefiniteDate { get; set; }
        public List<ReserveRoom> Room { get; set; }
        //public List<ReserveService> Services { get; set; }

    }
}
