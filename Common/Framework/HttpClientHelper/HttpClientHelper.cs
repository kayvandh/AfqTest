using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Framework.HttpClientHelper
{
    public class HttpClientHelper : IHttpClientHelper
    {
        public async Task<TResponse> GetAsync<TResponse, TError>(
            HttpClient client,
            string requestUri,
            Dictionary<string, string> parameters = null,
            Dictionary<string, string> headers = null,
            JsonSerializerOptions options = null)
        {
            try
            {
                options ??= new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (parameters != null)
                {
                    requestUri = QueryHelpers.AddQueryString(requestUri, parameters);
                }

                using var request = new HttpRequestMessage(HttpMethod.Get, requestUri);

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }

                using var response = await client.SendAsync(request);
                var statusCode = (int)response.StatusCode;
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    TError errorData = default;
                    try
                    {
                        errorData = JsonSerializer.Deserialize<TError>(responseContent, options);
                    }
                    catch
                    {
                        throw;
                    }

                    throw new ApiException(statusCode, responseContent, errorData?.ToString());
                }

                return JsonSerializer.Deserialize<TResponse>(responseContent, options);
            }
            catch (Exception ex)
            {
                throw new ApiException(500, ex.Message, "Unhandled exception occurred.");
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse, TError>(
                TRequest request,
                HttpClient client,
                string requestUri,
                Dictionary<string, string> headers = null,
                JsonSerializerOptions options = null)
        {
            try
            {
                options ??= new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var requestJson = JsonSerializer.Serialize(request, options);
                using var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

                using var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri)
                {
                    Content = requestContent
                };

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        requestMessage.Headers.Add(header.Key, header.Value);
                    }
                }

                using var response = await client.SendAsync(requestMessage);
                var statusCode = (int)response.StatusCode;
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    TError errorData = default;
                    try
                    {
                        errorData = JsonSerializer.Deserialize<TError>(responseContent, options);
                    }
                    catch
                    {
                        throw;
                    }

                    throw new ApiException(statusCode, responseContent, errorData?.ToString());
                }

                return JsonSerializer.Deserialize<TResponse>(responseContent, options);
            }
            catch (Exception ex)
            {
                throw new ApiException(500, ex.Message, "Unhandled exception occurred.");
            }
        }
    }
}
