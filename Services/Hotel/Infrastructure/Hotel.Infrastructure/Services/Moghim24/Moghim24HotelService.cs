using Framework.HttpClientHelper;
using Hotel.Application.Common.Models;
using Hotel.Application.Common.Services;
using Hotel.Infrastructure.Services.Moghim24.Models;


namespace Hotel.Infrastructure.Services.Moghim24
{
    public class Moghim24HotelService(IHttpClientFactory httpClientFactory, IHttpClientHelper httpClientHelper) : IHotelService
    {
        const int ProviderId = 1;
        const string Username = "AfaghSeir";
        const string Password = "Afagh@10188";

        private readonly HttpClient client = httpClientFactory.CreateClient(ServiceInformation.GetServiceInfo(ProviderId).ServiceKey);

        public async Task<HotelSearchResponse> HotelSearch(HotelSearchRequest request, Guid searchId, string serviceKey, HotelSearchHelper helper)
        {
            try
            {
                var token = await GetToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var serviceRequest = new Moghim24.Models.HotelAvailRequest()
                {
                    CheckInDate = request.CheckInDate.ToString("yyyy/MM/dd"),
                    CheckOutDate = request.CheckOutDate.ToString("yyyy/MM/dd"),
                    City = new List<string>() { helper.City.ProviderCities.FirstOrDefault(p => p.ProviderId == ProviderId).Code },
                    DateFormat = "miladi",
                    RoomCapacity = request.Rooms.Select(p => p.Adult).ToList(),
                };

                var serviceResult = await httpClientHelper.PostAsync<HotelAvailRequest, Response<List<HotelAvail>>>(serviceRequest, client, "/api/3.0/Hotel/Avail");


                var result = new HotelSearchResponse()
                {
                    HotelResults = serviceResult.Data.Select(p => new HotelResult()
                    {
                        ProviderId = ProviderId,
                        HotelId = Guid.NewGuid(),
                        CityId = request.CityId,
                        Title = p.HotelName,
                        Address = p.LocationInfo.Address,                        
                        CityTitle = p.LocationInfo.CityFaName,
                        Stars = p.Grade,
                        ChildPolicyAge = p.MinFreeChildAge,
                        RoomResults = p.Rooms.Select(q => new HotelRoomPackage()
                        {
                            PackageId = Guid.NewGuid(),
                            CheckInTime = 0,
                            CheckOutTime = 0,
                            TotalPrice = q.PricesInfo.Details.Sum(p=>p.RoomPrice),
                            Rooms = new List<HotelRoom>()
                             {
                                new HotelRoom()
                                {
                                    RoomId = Guid.Parse(q.RoomId),
                                    RoomIndex = q.RoomIndex,
                                    Title = q.RoomName,
                                    Capacity = q.RoomCapacity,
                                    TotalPirce = q.PricesInfo.Details.Sum(r=>r.RoomPrice),
                                    DailyPrice = q.PricesInfo.Details.Average(r=>r.RoomPrice),
                                    Board = q.ServiceInfo.BreakFast? "Beakfast" : "None",
                                    Description = q.ServiceInfo.Other,
                                    BedType = string.Empty,
                                }
                             }
                        }).ToList(),
                        MinimumTotalPrice = p.Rooms.Select(p => p.PricesInfo.Details.Sum(t => t.RoomPrice)).Min(p => p),
                        CanBook = true,
                        CanReserve = true,                        
                    }).ToList()
                };
                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task<HotelInfoResponse> HotelInfo(Application.Common.Models.HotelInfoRequest request)
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

        private async Task<string> GetToken()
        {
            //First Should be get from cach if it is not avalable try to get from service again

            try
            {
                var request = new AuthenticationRequest()
                {
                    Service = "MoghimHotel",
                    UserName = Username,
                    Md5Password = Framework.Encryption.Md5Hasher.GenerateMd5(Password)
                };

                using (var authClient = new HttpClient())
                {
                    authClient.BaseAddress = new Uri("https://identity.moghim24.services");

                    var result = await httpClientHelper.PostAsync<AuthenticationRequest, Response<AuthenticationResponse>>(request, authClient, "/api/Authentication/login");
                    if (result != null && result.Issuccess)
                    {
                        return result.Data.Token;
                    }
                    else
                    {
                        throw new Exception(result?.Errors.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
