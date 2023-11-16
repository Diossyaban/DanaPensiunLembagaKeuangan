using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Identity;

namespace Test1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddControllersWithViews().AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
            //});

            //var builder = DPLK.CreateBuilder(args);

            //builder.Services.AddRazorPages();
            //builder.Services.AddControllersWithViews();

            //builder.Services.AddDistributedMemoryCache();

            //builder.Services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromSeconds(10);
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});

            //var app = builder.Build();

            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Error");
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseSession();

            //app.MapRazorPages();
            //app.MapDefaultControllerRoute();

            //app.Run();
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
