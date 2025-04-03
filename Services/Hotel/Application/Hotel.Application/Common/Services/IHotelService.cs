using Hotel.Application.Common.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Services
{
    public interface IHotelService
    {
        Task HotelSearch(HotelSearchRequest request,Guid searchId,string serviceKey);

        Task<HotelInfoResponse> HotelInfo(HotelInfoRequest request);

        Task<ReserveResponse> Reserve(ReserveRequest request);

        Task<BookResponse> Book(BookRequest request);
    }
}
