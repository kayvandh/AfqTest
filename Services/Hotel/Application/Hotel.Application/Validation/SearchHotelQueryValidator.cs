using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Application.Query;

namespace Hotel.Application.Validation
{
    public class SearchHotelQueryValidator : AbstractValidator<SearchHotelQuery>
    {
        public SearchHotelQueryValidator()
        {
            RuleFor(p => p.CityId)
                .GreaterThan(0).NotEmpty().WithMessage("CityId is required");

            RuleFor(p=>p.CheckInDate)
                .NotEmpty().WithMessage("CheckInDate is required");

            RuleFor(p => p.CheckOutDate)
                .NotEmpty().WithMessage("CheckInDate is required")
                .GreaterThan(p=>p.CheckInDate).WithMessage("CheckOutDate must be grater than CheckInDate");

            RuleFor(p => p.Rooms)
                .Must(p => p != null && p.Any()).WithMessage("At Least one room information is required");


            RuleForEach(p => p.Rooms)
                .ChildRules(c =>
                {
                    c.RuleFor(p => p.Adult)
                        .GreaterThan(0).WithMessage("Adult count must have minimum value of 1");

                    c.RuleFor(p => p.ChildAges)
                        .Must((r, c) => c != null && c.Count == r.Child).WithMessage("Number of child ages must match the child count.")
                        .When(p => p.Child > 0);
                });
        }
    }
}
