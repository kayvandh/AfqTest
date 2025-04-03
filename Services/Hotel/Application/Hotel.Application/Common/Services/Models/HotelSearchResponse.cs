using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services.Models
{
    public class HotelSearchResponse
    {
        public Guid SearchId { get; set; }
        public HotelSearchRequest Request { get; set; }
        public List<HotelResult> HotelResults { get; set; }        
    }
}
