using Framework.Mapping.Interfaces;
using Hotel.Application.Common.Services.Models;
using MediatR;


namespace Hotel.Application.Query
{
    public class HotelSearchQuery : IRequest<FluentResults.Result<HotelSearchResponse>>, IOneWayMap<HotelSearchRequest>
    {
        public int CityId { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public List<RoomSearch> Rooms { get; set; }
    }
    public class RoomSearch : IOneWayMap<RoomSearchRequest>
    {
        public int Adult { get; set; }
        public int Child { get; set; }
        public List<int> ChildAges { get; set; }
    }
}
