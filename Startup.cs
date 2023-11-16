using DPLK.ModelAcc;
using DPLK.Models.context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DPLK.Service;
using DPLK.Controllers;

namespace Test1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PensionContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Pension")));
            services.AddDbContext<PensionAccContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PensionAcc")));

            services.AddHttpClient();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/account/login";
                    options.AccessDeniedPath = "/account/accessdenied";
                });

            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(new AuthorizeFilter());
            //    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            //}).SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddControllersWithViews();

            services.AddScoped<IAccountService, AccountService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Use(async (context, next) =>
            //{
            //    if (!context.User.Identity.IsAuthenticated)
            //    {
            //        context.Response.Redirect("/account/login");
            //    }
            //    else
            //    {
            //        await next();
            //    }
            //});
        }
    }
}
