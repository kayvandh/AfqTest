using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Query
{
    public class GetAllCityQuery : IRequest<FluentResults.Result<List<Common.Models.City>>>
    {
    }
}
