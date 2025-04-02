using AfqTest.Application;
using AfqTest.Infrastructure;
using Framework.ApiResponse;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.OpenApi.Models;
using System.IO.Compression;

namespace AfqTest.ApiService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.AddServiceDefaults();
            builder.Services.AddProblemDetails();

            builder.Services.AddControllers()
               .ConfigureApiBehaviorOptions(options =>
               {
                   options.InvalidModelStateResponseFactory = context => context.ToApiResponse();
               });

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddApplication(builder.Configuration)
                .AddInfrastructure(builder.Configuration);

            builder.Services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.Providers.Add<GzipCompressionProvider>();
            });

            builder.Services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            builder.Services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Afq.API", Version = "v1" });
            });
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Afq.API v1"));
            app.UseCors(options =>
                options.AllowAnyHeader()
                       .AllowAnyOrigin()
                       .AllowAnyMethod());

            app.UseRouting();
            app.MapControllers();
            app.UseExceptionHandler();

            app.Run();
        }
    }
}


