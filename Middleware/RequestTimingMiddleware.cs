using System.Diagnostics;

namespace COMP003B.SP26.FinalProject.ZachJ.Middleware
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //method path and execution time
            var clock = Stopwatch.StartNew();
            

            await _next(context);

            clock.Stop();
            
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}\n[Execution Time] {clock.Elapsed.Milliseconds} ms.");
            
        }
    }
}
