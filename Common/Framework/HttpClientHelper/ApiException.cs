using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.HttpClientHelper
{
    public class ApiException : Exception
    {
        public int StatusCode { get; }
        public string ResponseContent { get; }

        public ApiException(int statusCode, string responseContent, string message = null)
            : base(message ?? $"Request failed with status code {statusCode}")
        {
            StatusCode = statusCode;
            ResponseContent = responseContent;
        }
    }
}
