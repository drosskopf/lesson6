using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace webapp
{
    public class MiddlewareA
    {
        private readonly RequestDelegate _next;
        public MiddlewareA(RequestDelegate next){
            _next = next;
        }
        public async Task Invoke (HttpContext httpContext){
            try{
                Debug.WriteLine("Middleware A Start");
                await _next(httpContext);
                Debug.WriteLine("Middleware A End");
            }
            catch(Exception e){
                await httpContext.Response.WriteAsync("<h1>Doh!!!!</h1>");
            }
        }

    }

}