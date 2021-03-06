using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SneakerShop.Data;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Mocks;
using Microsoft.EntityFrameworkCore;
using SneakerShop.Data.Models;
using SneakerShop.Data.Repository;

namespace SneakerShop
{
    public class Startup
    {

        private IConfigurationRoot _confSting;

        public Startup(IHostingEnvironment hostEvn)
        {
            _confSting = new ConfigurationBuilder().SetBasePath(hostEvn.ContentRootPath).AddJsonFile("dbsettings.json")
                .Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
            services.AddTransient<ISneakers, SneakerRepository>();
            services.AddTransient<ISneakersCategory, CategoryRepository>();
            services.AddTransient<IOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();//404
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Sneakers/{action}/{category?}", defaults: new
                    { Controller = "Sneakers", action = "Index" });
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
