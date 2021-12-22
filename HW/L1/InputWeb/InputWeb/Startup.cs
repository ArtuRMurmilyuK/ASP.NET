using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                app.Run(async (context) =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";

                    // если обращение идет по адресу "/postuser", получаем данные формы
                    if (context.Request.Path == "/postuser")
                    {
                        var form = context.Request.Form;
                        string login = form["login"];
                        string password = form["password"];

                        if(login =="login" && password == "qwerty")
                        {
                            await context.Response.WriteAsync($"<div><p>ƒобро пожаловать!</p><p>");
                        }
                        else
                        {
                            await context.Response.WriteAsync("Ќеверный пароль");
                        }
                        
                    }
                    else
                    {
                        await context.Response.SendFileAsync("html/index.html");
                    }
                });
            });            
        }
    }
}
