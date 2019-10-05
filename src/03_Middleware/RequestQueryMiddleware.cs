using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Middleware
{
    public class RequestQueryMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestQueryMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Query.Keys.Count > 0)
            {
                foreach(var key in context.Request.Query.Keys)
                {
                    var data = context.Request.Query[key];
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        context.Request.Headers.Append(key, data);
                    }
                }
            }
            await _next(context);
        }
    }
}
