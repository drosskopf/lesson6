using Microsoft.AspNetCore.Builder;

namespace webapp{
    public static class MiddlewareExtensions{
        public static IApplicationBuilder UseMiddlewareA(this IApplicationBuilder builder){
             return builder.UseMiddleware<MiddlewareA>();
        }
        public static IApplicationBuilder UseMiddlewareB(this IApplicationBuilder builder){
             return builder.UseMiddleware<MiddlewareB>();
        }

    }

}