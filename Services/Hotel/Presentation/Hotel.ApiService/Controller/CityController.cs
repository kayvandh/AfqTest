using Framework.ApiResponse;
using Hotel.Application.Common.Models;
using Hotel.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Hotel.ApiService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [Route("GetCities")]
        [ProducesResponseType(typeof(ApiResponse<List<City>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse<List<City>>), (int)HttpStatusCode.BadRequest)]
        public async Task<ApiResponse<List<City>>> GetCities()
        {
            var request = new GetAllCityQuery();
            var result = await mediator.Send(request);
            return result.ToApiResponse();
        }
    }
}
