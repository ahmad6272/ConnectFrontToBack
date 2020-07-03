using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.DAL;
using ConnectFrontToBack.Helpers;
using ConnectFrontToBack.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectFrontToBack
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });

            services.AddIdentity<AppUser, IdentityRole>(IdentityOptions =>
            {
                IdentityOptions.Password.RequireDigit = true;
                IdentityOptions.Password.RequireLowercase = true;                            // маленькие буквы
                IdentityOptions.Password.RequireUppercase = true;                            // большие буквы
                IdentityOptions.Password.RequireNonAlphanumeric = true;                      // можно употреблять символы 
                IdentityOptions.Password.RequiredLength = 8;                                 // длина пароля 

                IdentityOptions.User.RequireUniqueEmail = true;                              // Юзер не может регаться одним и тем же эмейлом

                IdentityOptions.Lockout.MaxFailedAccessAttempts = 3;                         // Максимальное количество попыток входа 
                IdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);    // Блоеикрует вход этому юзеру на опред. время 

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders().AddErrorDescriber<CustomIdentityErrors>();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "areas",
                   template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{Id?}"
                );
            });
        }
    }
}
