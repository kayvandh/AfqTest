using Framework.HttpClientHelper;
using Framework.Utility;
using Hotel.Application.Common;
using Hotel.Application.Common.Models;
using Hotel.Application.Common.Services;
using Hotel.Infrastructure.Services.Eghamat24.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24
{
    public class Eghamat24HotelService(IHttpClientFactory httpClientFactory,IHttpClientHelper httpClientHelper) : IHotelService
    {
        const int ProviderId = 2;
        const string Token = "https://api.grschannel.com-$2y$10$C1KjxpL1eudyeFo2XPxx0eB";

        private readonly HttpClient client = httpClientFactory.CreateClient(ServiceInformation.GetServiceInfo(ProviderId).ServiceKey);

        public async Task<HotelSearchResponse> HotelSearch(HotelSearchRequest request, Guid searchId, string serviceKey, HotelSearchHelper helper)
        {
            try
            {
                var header = new Dictionary<string, string>()
                {
                    { "Client-Token", Token },
                };
                
                var serviceRequest = new SuggestionRequest()
                {
                    RoomsCount = request.Rooms.Count,
                    AdultCount = request.Rooms.Sum(p => p.Adult),
                    Children = request.Rooms.SelectMany(p=>p.ChildAges).ToList(),
                    CheckInDate = request.CheckInDate,
                    CheckOutDate = request.CheckOutDate,
                    CityId = Convert.ToInt32(helper.City.ProviderCities.FirstOrDefault(p => p.ProviderId == ProviderId).Code),
                };
                
                var serviceResult = await httpClientHelper.GetAsync<Response<SugesstionResult>>(client, "/v1/suggestion", DictionaryConverter.ToDictionary(serviceRequest), header);
            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }

        public Task<HotelInfoResponse> HotelInfo(HotelInfoRequest request)
        {
            
            throw new NotImplementedException();

        }
        public Task<ReserveResponse> Reserve(Application.Common.Models.ReserveRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<BookResponse> Book(BookRequest request)
        {
            throw new NotImplementedException();
        }


    }
}

