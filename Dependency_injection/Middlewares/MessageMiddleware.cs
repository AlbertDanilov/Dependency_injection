

using Dependency_injection.Services;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Dependency_injection.Middlewares
{
    public class MessageMiddleware
    {
        private readonly RequestDelegate _next;

        public MessageMiddleware(RequestDelegate next) {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context, IMessageSender messagtSender) {
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync(messagtSender.Send());
        }
    }
}
