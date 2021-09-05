﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieM.Client.Areas.Identity.Data;
using MovieM.Client.Data;

[assembly: HostingStartup(typeof(MovieM.Client.Areas.Identity.IdentityHostingStartup))]
namespace MovieM.Client.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<MovieMClientContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("MovieMClientContextConnection")));

                //services.AddDefaultIdentity<MovieMClientUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<MovieMClientContext>();
            });
        }
    }
}