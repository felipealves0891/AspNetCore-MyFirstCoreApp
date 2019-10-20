using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyFirstCoreApp.src.MyConsoleLogger;

namespace MyFirstCoreApp.src.MyMiddleware
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var services = httpContext.RequestServices;
            var log = (ILog)services.GetService(typeof(ILog));
            log.info("Index method executing");
            return _next(httpContext);
        }
    }
}