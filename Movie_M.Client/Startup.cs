using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Movie_M.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_M.Client
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

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            }); services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            services.AddTransient<IEmailSender, EmailSender>();
            //services.AddHangfire(conf => conf.UseMemoryStorage());
            //services.AddHangfireServer();
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddSession(opt =>
            {
                opt.IdleTimeout = System.TimeSpan.FromDays(10);
            });
            //services.AddSingleton<IRecurringNetflixJob, RecurringNetflixJob>();
            services.AddRazorPages();
            services.AddAuthentication()
        .AddGoogle(googleOptions =>
        {
            googleOptions.ClientId = "277229731378-iqjonc4gus2uqo1npbdlhuekisfkhbp1.apps.googleusercontent.com";
            googleOptions.ClientSecret = "ZflWc7BHfRxnXCxsLHM9v20D";
        });
            //.AddTwitter(twitterOptions => { ... })
            //.AddFacebook(facebookOptions => { ... });

        }
        //, IBackgroundJobClient backgroundJobClient, IRecurringJobManager jobManager, IServiceProvider serviceProvider
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
            app.UseSession();
            app.UseHttpsRedirection();
            //app.UseHangfireDashboard();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            //backgroundJobClient.Enqueue(() => Console.WriteLine("Hello Hangfire job!"));
            //jobManager.AddOrUpdate("Run", () => serviceProvider.GetService<IRecurringNetflixJob>().GetMoviePublishInNetflix(), "* * * * *", TimeZoneInfo.Local);

        }
    }
}
