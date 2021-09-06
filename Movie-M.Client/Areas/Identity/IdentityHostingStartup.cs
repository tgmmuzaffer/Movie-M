using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Movie_M.Client.Areas.Identity.Data;
using Movie_M.Client.Data;

[assembly: HostingStartup(typeof(Movie_M.Client.Areas.Identity.IdentityHostingStartup))]
namespace Movie_M.Client.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Movie_MClientContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Movie_MClientContextConnection")));

                services.AddDefaultIdentity<Movie_MClientUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Movie_MClientContext>();
            });
        }
    }
}