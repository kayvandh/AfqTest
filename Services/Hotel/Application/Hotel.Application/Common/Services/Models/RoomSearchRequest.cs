using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services.Models
{
    public class RoomSearchRequest
    {
        public int Adult { get; set; }
        public int Child { get; set; }
        public List<int> ChildAges { get; set; }
    }
}
