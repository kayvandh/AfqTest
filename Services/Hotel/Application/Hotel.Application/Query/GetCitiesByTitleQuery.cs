using Hotel.Application.Common.Models;
using MediatR;


namespace Hotel.Application.Query
{
    public class GetCitiesByTitleQuery : IRequest<FluentResults.Result<List<City>>>
    {
        public string Title { get; set; }
    }
}
