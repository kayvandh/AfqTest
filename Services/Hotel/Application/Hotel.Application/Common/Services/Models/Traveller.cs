using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services.Models
{
    public class Traveller
    {
        public int RoomIndex { get; set; }
        public TravellerType TravellerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public string NationalId { get; set; }
        public string PassportNumber { get; set; }
        public int? Age { get; set; }
    }

    public enum TravellerType
    {
        Adult = 1,
        Child = 2
    }
}
