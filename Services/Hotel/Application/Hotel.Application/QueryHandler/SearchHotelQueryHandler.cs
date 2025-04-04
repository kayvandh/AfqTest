using AutoMapper;
using Framework.Extenstions;
using Hotel.Application.Common;
using Hotel.Application.Common.Models;
using Hotel.Application.Common.Repositories;
using Hotel.Application.Common.Services;
using Hotel.Application.Query;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;


namespace Hotel.Application.QueryHandler
{
    public class SearchHotelQueryHandler(IMapper mapper, IServiceProvider serviceProvider, KeyedServiceTracker tracker,IMemoryCache memoryCache,ICityRepository cityRepository) 
        : IRequestHandler<SearchHotelQuery, FluentResults.Result<HotelSearchResponse>>
    {

        public async Task<FluentResults.Result<HotelSearchResponse>> Handle(SearchHotelQuery request, CancellationToken cancellationToken)
        {
            var result = new FluentResults.Result<HotelSearchResponse>();
            try
            {
                var hotelSearchRequest = mapper.Map<HotelSearchRequest>(request);
                var tasks = new List<Task<HotelSearchResponse>>();
                

                var searchId = Guid.NewGuid();
                var helper = new HotelSearchHelper() 
                { 
                    City = mapper.Map<Application.Common.Models.City>(await cityRepository.GetById(request.CityId)),
                };

                foreach (var serviceTracker in tracker.GetServiceTrackers())
                {
                    var service = serviceProvider.GetRequiredKeyedService<IHotelService>(serviceTracker.ServiceKey);

                    tasks.Add(service.HotelSearch(hotelSearchRequest, searchId, serviceTracker.ServiceKey, helper));
                }

                var responses = await Task.WhenAll<HotelSearchResponse>(tasks);

                var searchResult = new HotelSearchResponse()
                {
                    SearchId = searchId,
                    Request = hotelSearchRequest,
                    HotelResults = new List<HotelResult>()
                };

                foreach(var response in responses)
                {
                    if(response != null)
                    {
                        searchResult.HotelResults.AddRange(response.HotelResults);  
                    }
                }

                memoryCache.Set<HotelSearchResponse>($"Hotel_{searchId}", searchResult, TimeSpan.FromMinutes(15));

                result.WithValue(searchResult);
                result.WithSuccess("Search Completed");
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
