using Hotel.Application.Common.Services;
using Hotel.Application.Common.Services.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24
{
    public class Eghamat24HotelService(IMemoryCache memoryCache) : IHotelService
    {
        int providerId = 2;
        public async Task HotelSearch(HotelSearchRequest request, Guid searchId, string serviceKey)
        {
            await Task.Run(() =>
            {
                var result = new HotelSearchResponse()
                {
                    SearchId = searchId,
                    HotelResults = new List<HotelResult>() { new HotelResult() { ProviderId = providerId, Title = " Test 2" } }
                };
                memoryCache.Set($"Hotel_{serviceKey}_{searchId}", result,TimeSpan.FromMinutes(15));
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
