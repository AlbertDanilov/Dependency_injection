using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace Dependency_injection
{
    public class Startup
    {
        private IServiceCollection _services;

        public void ConfigureServices(IServiceCollection services)
        {
            //var servs = services.ToList(); //встроенные сервисы фреймворка

            services.AddMvc(); //регистрация дополнительных встроенных сервисов ASP.NET Core, например MVC
            _services = services;

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            app.Run(async context =>
            {
                var sb = new StringBuilder();
                sb.Append("<h1>Все сервисы</h1>");
                sb.Append("<table>");
                sb.Append("<tr><th>Тип</th><th>Lifetime</th><th>Реализация</th></tr>");
                foreach (var svc in _services)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td>{svc.ServiceType.FullName}</td>");
                    sb.Append($"<td>{svc.Lifetime}</td>");
                    sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                context.Response.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync(sb.ToString());
            });
        }
    }
}
