using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services.Models
{
    public class HotelRoom
    {
        public int RoomIndex { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Board { get; set; }
        public string SerivceType { get; set; }
        public string BedType { get; set; }
        public int Capacity { get; set; }
        public bool Refundable { get; set; }
        public double DailyPrice { get; set; }
        public double TotalPirce { get; set; }        
    }
}
