using System;

using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopYB.Models;
using SmartBreadcrumbs.Extensions;

namespace Shop_YB
{
    public class Startup
    {

        public IConfiguration configuration { get; }

        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(opt =>
            {
                
                opt.DefaultScheme = "User_Schema";
            }).AddCookie("User_Schema", opt =>
            {
                opt.LoginPath = "/customer/login";
                opt.LogoutPath = "/customer/signout";
                opt.AccessDeniedPath = "/customer/accessdenied";
            }).AddCookie("Admin_Schema", opt =>
             {
                 opt.LoginPath = "/admin/login";
                 opt.LogoutPath = "/admin/login/signout";
                 opt.AccessDeniedPath = "/admin/account/accessdenied";
             });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
               // opt.Cookie.Expiration = TimeSpan.FromHours(500);
            });
            
           
           /* services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/admin/login/index";
                    options.LogoutPath = "/admin/login/signout";
                    options.AccessDeniedPath = "/admin/account/accessdenied";
                });
              */
            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddSessionStateTempDataProvider();
            
            services.AddBreadcrumbs(GetType().Assembly,option=>
            {
                option.TagName = "nav";
                option.TagClasses = "";
                option.OlClasses = "breadcrumb";
                option.LiClasses = "breadcrumb-item";
                option.ActiveLiClasses = "breadcrumb-item active";
                option.SeparatorElement = "<li class=\"separator\"> / </li>";
            });

            //services.AddJsReport(new LocalReporting() 
            //  .UseBinary(JsReportBinary.GetBinary())
            //  .AsUtility()
            //  .Create());


            var connection = configuration.GetConnectionString("defaultconnection");
            services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies().UseSqlServer(connection));
           


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                var principal = new ClaimsPrincipal();

                var result1 = await context.AuthenticateAsync("User_Schema");

                if (result1?.Principal != null)
                {
                    principal.AddIdentities(result1.Principal.Identities);
                }

                var result2 = await context.AuthenticateAsync("Admin_Schema");

                if (result2?.Principal != null)
                {
                    principal.AddIdentities(result2.Principal.Identities);
                }
                context.User = principal;

                await next();

            });



            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseStaticFiles();
            var cookiePolicy = new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict
            };
            app.UseCookiePolicy(cookiePolicy);


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseMvc(route =>
            //{
            //    //route.MapRoute(
            //    //    name: "category",
            //    //    template: "product/{id}/{productName}",
            //    //    defaults:new { controller="product",action= "Category" });

            //    route.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=index}/{id?}");
            //});
        }
    }
}
