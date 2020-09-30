using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW_03.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HW_03
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(convertUrlConnectionString(Configuration["DATABASE_URL"])));
            services.AddControllersWithViews();
            services.AddTransient<IRepository, PostgresRepository>();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        private string convertUrlConnectionString(string url)
        {
            if (!url.Contains("//"))
                return url;



            var uri = new Uri(url);
            var host = uri.Host;
            var port = uri.Port;
            var database = uri.Segments.Last();
            var parts = uri.AbsoluteUri.Split(':', '/', '@');
            var user = parts[3];
            var password = parts[4];



            return $"host={host}; port={port}; database={database}; username={user}; password={password}; SSL Mode=Prefer; Trust Server Certificate=true";
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "Blog",
                    defaults: new { controller = "Blog", action = "Posts" });
                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "Blog/{id?}",
                    defaults: new { controller = "Blog", action = "Detail" });
                endpoints.MapControllerRoute(
                    name: "Edit",
                    pattern: "{controller=Blog}/{action=Posts}/{id?}");

            });
        }
    }
}
