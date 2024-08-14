using EduDom.Core.Application.Interfaces.Services;
using EduDom.Infraestructure.Identity.Entities;
using EduDom.Infraestructure.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Infraestructure.Identity
{
    public static class ServiceResgistration
    {
        public static void AddIdentityInfrastructure(this IServiceCollection service, IConfiguration config)
        {
            //if (config.GetValue<bool>("UseInMemoryDatabase"))
            //{
            //    service.AddDbContext<IdentityContext>(options => options.UseInMemoryDatabase("IdentityDb"));
            //}
            //else
            //{
            //    service.AddDbContext<IdentityContext>(options =>
            //        options.UseSqlServer(config.GetConnectionString("IdentityConnection"),
            //        m => m.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName)));
            //}

            //#region 'Identity'
            //service.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<IdentityContext>()
            //    .AddDefaultTokenProviders();

            //service.ConfigureApplicationCookie(opts =>
            //{
            //    opts.LoginPath = "/User";
            //    opts.AccessDeniedPath = "/User/AccessDenied";
            //});

            //service.AddAuthentication();
            //#endregion

            //#region 'Services'
            //service.AddTransient<IAccountServices, AccountService>();
            //#endregion
        }
    }
}
