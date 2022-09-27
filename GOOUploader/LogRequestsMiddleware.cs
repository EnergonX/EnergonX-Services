using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GOOUploader
{
    public class LogRequestsMiddleware

    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LogRequestsMiddleware> _logger;
        public static readonly List<string> RequestHeaders = new List<string>();
        public static readonly List<string> ResponseHeaders = new List<string>();

        public LogRequestsMiddleware(RequestDelegate next, ILogger<LogRequestsMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            // enable unique request headers browsing
            var uniqueRequestHeaders = context.Request.Headers
                .Where(x => RequestHeaders.All(r => r != x.Key))
                .Select(x => x.Key);
            RequestHeaders.AddRange(uniqueRequestHeaders); 

            try
            {
                await _next(context);
            }
            finally
            {
                _logger.LogInformation(
                    "Request {method} {url} => {statusCode}",
                    context.Request?.Method,
                    context.Request?.Path.Value,
                    context.Response?.StatusCode);

                // enable uniqe response headers 
                var uniqueResponseHeaders = context.Response.Headers
                .Where(x => ResponseHeaders.All(r => r != x.Key))
                .Select(x => x.Key);
                ResponseHeaders.AddRange(uniqueResponseHeaders);
            }
        }
    }
}
