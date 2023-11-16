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
using System;

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
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            }); services.AddDbContext<PensionContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Pension")));
            services.AddDbContext<PensionAccContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PensionAcc")));

            services.AddHttpClient();
            services.AddControllersWithViews();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    //.AddCookie(x => x.LoginPath = "/account/login");
            //    .AddCookie(options =>
            //    {
            //        options.Cookie.Name = "mysession";
            //        options.LoginPath = "/account/login";
            //        //options.AccessDeniedPath = "/account/accessdenied";
            //    });
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "JWT_OR_COOKIE";
                options.DefaultChallengeScheme = "JWT_OR_COOKIE";
            })
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/login";
                        options.ExpireTimeSpan = TimeSpan.FromDays(1);
                    })
                    .AddPolicyScheme("JWT_OR_COOKIE", "JWT_OR_COOKIE", options =>
                    {
                        options.ForwardDefaultSelector = context =>
                        {
                  

                            return CookieAuthenticationDefaults.AuthenticationScheme;
                        };
                    });


            //services.AddAuthentication(options =>
            //{
            //    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            //});
            services.AddMvc().AddMvcOptions(MvcOptions => { MvcOptions.EnableEndpointRouting = false; });


            //.AddCookie(options =>
            //{
            //    options.LoginPath = "/account/login";
            //    options.AccessDeniedPath = "/account/accessdenied";
            //});

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
            var cookiePolicyOptions = new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict,
                HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always,
                Secure = CookieSecurePolicy.None,
            };
            app.UseCookiePolicy(cookiePolicyOptions);
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseAuthentication();
            //app.UseAuthorization();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Use(async (context, next) =>
            {
                if (!context.User.Identity.IsAuthenticated)
                {
                    context.Response.Redirect("/account/login");
                }
                else
                {
                    await next();
                }
            });
        }
    }
}
