using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services
{
    public static class ServiceInformation
    {
        public const string Moghim24Service = "MOGHIM24";
        public const string Eghamat24Service = "EGHMAT24";

        public static List<HttpClientData> ServiceInfos = new List<HttpClientData>()
        {
            new HttpClientData(Moghim24Service, "https://hotel.moghim24.services"),
            new HttpClientData(Eghamat24Service, "https://api.grschannel.com")
        };           
    }

    public class HttpClientData
    {
        public HttpClientData(string title, string baseAddress)
        {
            Title = title;
            BaseAddress = baseAddress;
        }

        public string Title { get; set; }
        public string BaseAddress { get; set; }
    }
}
