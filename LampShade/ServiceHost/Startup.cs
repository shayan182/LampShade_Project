using _0_Framework.Application;
using BlogManagement.Infrastructure.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DiscountManagement.Configuration;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.Configuration;
using ShopManagement.Configuration;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using AccountManagement.Infrastructure.Configuration;
using CommentManagement.Infrastructure.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace ServiceHost
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
            services.AddHttpContextAccessor();
            var connectionString = Configuration.GetConnectionString("LampShadeDb");
            ShopManagementBootstrapper.Configure(services , connectionString );
            DiscountManagementBootstrapper.Configure(services , connectionString);
            InventoryManagementBootstrapper.Configure(services , connectionString);
            BlogManagementBootstrapper.Configure(services , connectionString);
            CommentManagementBootstrapper.Configure(services , connectionString);
            AccountManagementBootstrapper.Configure(services ,connectionString);
            services.AddSingleton(
                HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));

            services.AddTransient<IFileUploader, FileUploader>();
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IAuthHelper, AuthHelper>();
            services.AddDbContext<DiscountContext>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
                {
                    o.LoginPath = new PathString("/Account");
                    o.LogoutPath = new PathString("/Account");
                    o.AccessDeniedPath = new PathString("/AccessDenied");
                });


            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
