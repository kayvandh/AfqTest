using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services.Models
{
    public class HotelResult
    {
        public int ProviderId { get; set; }
        public int HotelId { get; set; }
        public int CityId { get; set; }
        public int Stars { get; set; }
        public string Title { get; set; }        
        public string Address { get; set; }
        public string MainImageUrl { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<string> Facilities { get; set; }
        public List<HotelAmenity> Amenities { get; set; }        
        public List<HotelRoomPackage> RoomResults { get; set; }
        public bool CanBook { get; set; }
        public bool CanReserve { get; set; }
        public double MinimumTotalPrice { get; set; }

        // to save extra information related provider 
        public string Properties { get; set; }

    }
}
