using Framework.ApiResponse;
using Hotel.Application.Common.Models;
using Hotel.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Hotel.ApiService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        [Route("SearchHotel")]
        [ProducesResponseType(typeof(ApiResponse<HotelSearchResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse<HotelSearchResponse>), (int)HttpStatusCode.BadRequest)]
        public async Task<ApiResponse<HotelSearchResponse>> SearchHotel([FromBody]SearchHotelQuery request)
        {
            var result = await mediator.Send(request);
            return result.ToApiResponse();
        }
    }
}
