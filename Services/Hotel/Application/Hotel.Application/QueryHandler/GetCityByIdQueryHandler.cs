using AutoMapper;
using FluentResults;
using Framework.Extenstions;
using Hotel.Application.Common.Models;
using Hotel.Application.Common.Repositories;
using Hotel.Application.Query;
using MediatR;


namespace Hotel.Application.QueryHandler
{
    public class GetCityByIdQueryHandler(ICityRepository cityRepository, IMapper mapper) : IRequestHandler<GetCityByIdQuery, FluentResults.Result<City>>
    {
        public async Task<Result<City>> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<City>();
            try
            {
                var city = await cityRepository.GetById(request.Id, false);

                result.WithValue(mapper.Map<Common.Models.City>(city));
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
