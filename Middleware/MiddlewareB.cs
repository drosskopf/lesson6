using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace webapp
{
    public class MiddlewareB
    {
        private readonly RequestDelegate _next;
        public MiddlewareB(RequestDelegate next){
            _next = next;
        }
        public async Task Invoke (HttpContext httpContext){
            try{
                Debug.WriteLine("Middleware B Start");
                await _next(httpContext);
                Debug.WriteLine("Middleware B End");
            }
            catch(Exception e){
                await httpContext.Response.WriteAsync("<h1>Doh!!!!</h1>");
            }
        }

    }

}