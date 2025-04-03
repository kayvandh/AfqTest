using AutoMapper;
using FluentResults;
using Framework.Extenstions;
using Hotel.Application.Common;
using Hotel.Application.Common.Services;
using Hotel.Application.Common.Services.Models;
using Hotel.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.QueryHandler
{
    public class HotelSearchQueryHandler(IMapper mapper, IServiceProvider serviceProvider, KeyedServiceTracker tracker,IMemoryCache memoryCache) 
        : IRequestHandler<HotelSearchQuery, FluentResults.Result<HotelSearchResponse>>
    {

        public async Task<FluentResults.Result<HotelSearchResponse>> Handle(HotelSearchQuery request, CancellationToken cancellationToken)
        {
            var result = new FluentResults.Result<HotelSearchResponse>();
            try
            {
                var hotelSearchRequest = mapper.Map<HotelSearchRequest>(request);
                var tasks = new List<Task>(); 
                
                var searchId = Guid.NewGuid();

                foreach (var key in tracker.GetKeys())
                {
                    var service = serviceProvider.GetRequiredKeyedService<IHotelService>(key);

                    tasks.Add(service.HotelSearch(hotelSearchRequest, searchId,key));
                }

                await Task.WhenAll(tasks);

                var searchResult = new HotelSearchResponse()
                {
                    SearchId = searchId,
                    Request = hotelSearchRequest,
                    HotelResults = new List<HotelResult>()
                };

                foreach (var key in tracker.GetKeys())
                {
                    var hotelSearchResponse = memoryCache.Get<HotelSearchResponse>($"Hotel_{key}_{searchId}");
                    if (hotelSearchResponse != null)
                    {
                        searchResult.HotelResults.AddRange(hotelSearchResponse.HotelResults);
                    }
                }

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
