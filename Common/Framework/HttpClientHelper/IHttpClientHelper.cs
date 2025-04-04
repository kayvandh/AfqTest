using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Framework.HttpClientHelper
{
    public interface IHttpClientHelper
    {
        Task<TResponse> GetAsync<TResponse>(
            HttpClient client,
            string requestUri,
            Dictionary<string, string> parameters = null,
            Dictionary<string, string> headers = null,
            JsonSerializerOptions options = null);

        Task<TResponse> GetAsync<TResponse, TError>(
            HttpClient client,
            string requestUri,
            Dictionary<string, string> parameters = null,
            Dictionary<string, string> headers = null,
            JsonSerializerOptions options = null);

        Task<TResponse> PostAsync<TRequest, TResponse>(
                        TRequest request,
                        HttpClient client,
                        string requestUri,
                        Dictionary<string, string> headers = null,
                        JsonSerializerOptions options = null);

        Task<TResponse> PostAsync<TRequest, TResponse, TError>(
                        TRequest request,
                        HttpClient client,
                        string requestUri,
                        Dictionary<string, string> headers = null,
                        JsonSerializerOptions options = null);
    }
}
