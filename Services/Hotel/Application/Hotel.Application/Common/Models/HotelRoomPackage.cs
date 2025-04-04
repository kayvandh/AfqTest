using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Models
{
    public class HotelRoomPackage
    {
        public Guid PackageId { get; set; }
        public int CheckInTime { get; set; }
        public int CheckOutTime { get; set; }
        public List<HotelRoom> Rooms { get; set; }
        public double TotalPrice { get; set; }

        // to save extra information related provider 
        public string Properties { get; set; }
    }
}
