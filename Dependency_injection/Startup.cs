using Dependency_injection.Classes;
using Dependency_injection.Extensions;
using Dependency_injection.Middlewares;
using Dependency_injection.Services;
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
        //private IServiceCollection _services;

        public void ConfigureServices(IServiceCollection services)
        {
            //var servs = services.ToList(); //встроенные сервисы фреймворка

            //services.AddMvc(); //регистрация дополнительных встроенных сервисов ASP.NET Core, например MVC
            //_services = services;

            //services.AddTransient<IMessageSender, EmailMessageSender>();
            //services.AddTransient<MessageService>();

            //services.AddTransient<IMessageSender, SmsMessageSender>();

            //services.AddTransient<TimeService>();
            //services.AddTimeService();

            services.AddTransient<IMessageSender, EmailMessageSender>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        //public void Configure(IApplicationBuilder app, MessageService messageSender)
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IMessageSender messageSender)
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TimeService timeService)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            app.UseMiddleware<MessageMiddleware>();

            //app.Run(async (context) =>
            //{
            //    //IMessageSender messageSender = context.RequestServices.GetService<IMessageSender>();
            //    IMessageSender messageSender = app.ApplicationServices.GetService<IMessageSender>();
            //    context.Response.ContentType = "text/html;charset=utf-8";
            //    await context.Response.WriteAsync(messageSender.Send());
            //});

            //app.Run(async (context) =>
            //{
            //    context.Response.ContentType = "text/html; charset=utf-8";
            //    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
            //});

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            //app.Run(async context =>
            //{
            //    var sb = new StringBuilder();
            //    sb.Append("<h1>Все сервисы</h1>");
            //    sb.Append("<table>");
            //    sb.Append("<tr><th>Тип</th><th>Lifetime</th><th>Реализация</th></tr>");
            //    foreach (var svc in _services)
            //    {
            //        sb.Append("<tr>");
            //        sb.Append($"<td>{svc.ServiceType.FullName}</td>");
            //        sb.Append($"<td>{svc.Lifetime}</td>");
            //        sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
            //        sb.Append("</tr>");
            //    }
            //    sb.Append("</table>");
            //    context.Response.ContentType = "text/html;charset=utf-8";
            //    await context.Response.WriteAsync(sb.ToString());
            //});
        }
    }
}
