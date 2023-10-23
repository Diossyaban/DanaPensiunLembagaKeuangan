using DPLK.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;

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

     /*       services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<PensionContext>()
                .AddDefaultTokenProviders();
*/
            // Konfigurasi Identity
            services.Configure<IdentityOptions>(options =>
            {
                // Konfigurasi opsi Identity sesuai kebutuhan
            });

            // Tambahkan autentikasi dan otentikasi eksternal jika diperlukan

            services.AddControllersWithViews();
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

            // Tambahkan middleware otentikasi di sini
            app.UseAuthentication();
            app.UseAuthorization();

            // ...

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
