using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Models
{
    public class HotelSearchRequest
    {
        public HotelSearchRequest()
        {
            Rooms = new List<RoomSearchRequest> { new RoomSearchRequest() { Adult = 1, Child = 0 } };
        }
        public int CityId { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public List<RoomSearchRequest> Rooms { get; set; }
    }
}
