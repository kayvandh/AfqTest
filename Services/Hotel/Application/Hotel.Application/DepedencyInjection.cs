using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Hotel.Application.Validation;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Hotel.Application
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(cfg => cfg.DisableConstructorMapping(), typeof(Mapping.ApplicationProfile).Assembly);

            services.Configure<AppSettings.Main>(
                configuration.GetSection(AppSettings.Main.Section));

            services.AddValidatorsFromAssemblyContaining<HotelSearchCommandValidator>();
            services.AddFluentValidationAutoValidation();
            return services;
        }
    }
}
