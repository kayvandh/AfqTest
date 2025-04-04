using Framework.HttpClientHelper;
using Hotel.Application.Common;
using Hotel.Application.Common.Models;
using Hotel.Application.Common.Services;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24
{
    public class Eghamat24HotelService(IHttpClientFactory httpClientFactory,IHttpClientHelper httpClientHelper) : IHotelService
    {
        const int ProviderId = 2;
        private readonly HttpClient client = httpClientFactory.CreateClient(ServiceInformation.GetServiceInfo(ProviderId).ServiceKey);

        public async Task<HotelSearchResponse> HotelSearch(HotelSearchRequest request, Guid searchId, string serviceKey, HotelSearchHelper helper)
        {
            return await Task.Run(() =>
            {
                var result = new HotelSearchResponse()
                {
                    SearchId = searchId,
                    HotelResults = new List<HotelResult>() { new HotelResult() { ProviderId = ProviderId, Title = " Test 2" } }
                };                
                return result;
            });
        }

        public Task<HotelInfoResponse> HotelInfo(HotelInfoRequest request)
        {
            
            throw new NotImplementedException();

        }

        public Task<ReserveResponse> Reserve(ReserveRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<BookResponse> Book(BookRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

