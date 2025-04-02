using Hotel.Application.Common.Services;
using Hotel.Application.Common.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Services.Eghamat24
{
    public class Eghamat24HotelService : IHotelService
    {
        public Task<HotelSearchResponse> HotelSearch(HotelSearchRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<HotelInfoResponse> HotelInfo(HotelInfoRequest request)
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
    }
}
