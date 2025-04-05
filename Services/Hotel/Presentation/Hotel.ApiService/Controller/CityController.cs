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
        [Route("GetAllCities")]
        [ProducesResponseType(typeof(ApiResponse<List<City>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse<List<City>>), (int)HttpStatusCode.BadRequest)]
        public async Task<ApiResponse<List<City>>> GetAllCities()
        {
            var result = await mediator.Send(new GetAllCityQuery());
            return result.ToApiResponse();
        }

        [HttpGet]
        [Route("GetCitiesByTitle")]
        [ProducesResponseType(typeof(ApiResponse<List<City>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse<List<City>>), (int)HttpStatusCode.BadRequest)]
        public async Task<ApiResponse<List<City>>> GetCitiesByTitle([FromQuery]GetCitiesByTitleQuery request)
        {            
            var result = await mediator.Send(request);
            return result.ToApiResponse();
        }

        [HttpGet]
        [Route("GetCityById")]
        [ProducesResponseType(typeof(ApiResponse<City>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse<City>), (int)HttpStatusCode.BadRequest)]
        public async Task<ApiResponse<City>> GetCityById([FromQuery] GetCityByIdQuery request)
        {            
            var result = await mediator.Send(request);
            return result.ToApiResponse();
        }
    }
}
