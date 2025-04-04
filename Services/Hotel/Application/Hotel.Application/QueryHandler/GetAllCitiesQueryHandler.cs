using AutoMapper;
using FluentResults;
using Framework.Extenstions;
using Hotel.Application.Common.Models;
using Hotel.Application.Common.Repositories;
using Hotel.Application.Query;
using MediatR;


namespace Hotel.Application.QueryHandler
{
    public class GetAllCitiesQueryHandler(ICityRepository cityRepository, IMapper mapper) : IRequestHandler<GetAllCityQuery, FluentResults.Result<List<Common.Models.City>>>
    {
        public async Task<Result<List<City>>> Handle(GetAllCityQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<List<City>>();
            try
			{
                var cities = await cityRepository.GetAllAsync(false);

                result.WithValue(cities.Select(mapper.Map<Common.Models.City>).ToList());
                result.WithSuccess(string.Empty);
			}
			catch (Exception ex)
			{
                result.WithError(ex.Message);
                result.WithErrors(ex.GetInnerExceptions().Select(e => e.Message));
            }
            return result;
        }
    }
}
