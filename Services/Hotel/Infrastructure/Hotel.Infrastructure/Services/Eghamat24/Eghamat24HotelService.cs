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

                var parameters = DictionaryConverter.ToDictionary(serviceRequest);
                var serviceResult = await httpClientHelper.GetAsync<Response<SugesstionResult>>(client, "/v1/suggestion", parameters, header);

                var result = new HotelSearchResponse()
                {
                    HotelResults = serviceResult.Value.Suggestions.Select(p=> new HotelResult() 
                    { 
                        ProviderId = ProviderId,
                        HotelId = Guid.NewGuid(),
                        CityId = request.CityId,
                        Title = p.PropertyName,
                        CityTitle = helper.City.TitleFa,
                        Address = string.Empty,
                        Stars = 0,
                        ChildPolicyAge = 0,
                        RoomResults = p.Rooms.Select(r=> new HotelRoomPackage()
                        {
                            PackageId = Guid.NewGuid(),
                            CheckInTime = 0,
                            CheckOutTime = 0,
                            TotalPrice = r.RatePlans.FirstOrDefault()?.TotalPrice ?? 0,
                            Rooms = new List<HotelRoom>() 
                            {
                                new HotelRoom()
                                {
                                    RoomId = Guid.NewGuid(),
                                    RoomIndex = 1,
                                    Title = r.RoomTypeName,
                                    BedType = r.RoomType,
                                    Board = r.RatePlans.FirstOrDefault()?.BoardType ?? string.Empty,
                                    Capacity = r.RoomTypeCapacity,
                                    DailyPrice = r.RatePlans.FirstOrDefault()?.DailyPrice ?? 0,
                                    TotalPirce = r.RatePlans.FirstOrDefault()?.TotalPrice ?? 0,
                                    Description = string.Empty,
                                    Refundable = r.RatePlans.FirstOrDefault().Cancelable == 1,
                                    SerivceType = string.Empty,                                    
                                }
                            },
                            Properties = System.Text.Json.JsonSerializer.Serialize(new { r.RoomTypeId, r.RoomTypeCapacity, r.RoomTypeExtraCapacity, })
                        }).ToList(),
                        MinimumTotalPrice = p.Rooms.Min(r => r.TotalPrice),
                        CanBook = true,
                        CanReserve = true,
                    }).ToList()
                };
                return result;
            }
            catch (Exception)
            {
                throw;
            }
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

