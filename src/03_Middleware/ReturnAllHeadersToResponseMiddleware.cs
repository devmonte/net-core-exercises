using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Middleware
{
    public class ReturnAllHeadersToResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public ReturnAllHeadersToResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            
            foreach(var header in context.Request.Headers)
            {
                await context.Response.WriteAsync($"\n {header.Key}: {header.Value}");
            }

            await _next(context);
        }
    }
}
