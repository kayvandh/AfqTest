using Framework.ApiResponse;
using Framework.Extenstions;
using Framework.HttpClientHelper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Framework.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(ApiException ex)
            {
                context.Response.StatusCode = 500;
                var response = new ApiResponse.ApiResponse()
                {
                    HasError = true,
                    HttpStatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Messages = { ex.ResponseContent }
                };
                await context.Response.WriteAsJsonAsync(response);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                var response = new ApiResponse.ApiResponse()
                {
                    HasError = true,
                    HttpStatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Messages = ex.GetInnerExceptions().Select(p => p.Message).ToList()
                };
                await context.Response.WriteAsJsonAsync(response);  
            }
        }
    }

    public static class UseExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
