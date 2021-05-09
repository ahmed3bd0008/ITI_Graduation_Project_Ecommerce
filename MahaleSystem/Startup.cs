using MahaleSystem.Models;
using MahaleSystem.Models.Identity;
using MahaleSystem.Repository.Implementation;
using MahaleSystem.Repository.Interface;
using MahaleSystem.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddServerSideBlazor();

            services.AddIdentity<CustomIdentityuser, CustomIdentityRole>().AddEntityFrameworkStores<ManahelContext>();
            services.AddDbContext<ManahelContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("MyConnection"));
            });
            services.AddIdentityCore<CustomIdentityuser>(options => options.SignIn.RequireConfirmedAccount = true)
              .AddEntityFrameworkStores<ManahelContext>()
              .AddTokenProvider<DataProtectorTokenProvider<CustomIdentityuser>>(TokenOptions.DefaultProvider);
            // services.AddScoped<SignInManager<CustomIdentityuser>, SignInManager<CustomIdentityuser>>();
            services.Configure<IdentityOptions>(option =>
            {
                option.Password.RequiredLength = 6;
                option.Password.RequiredUniqueChars = 0;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireUppercase = false;
            });
            services.AddAuthorization(option => {
                option.AddPolicy("addUser", police => police.RequireAssertion(context
                    => context.User.IsInRole("SuperAdmin") ||
                   context.User.HasClaim(claim => claim.Type == "AddUser")));
                option.AddPolicy("editUser", police => police.RequireAssertion(context =>
                      context.User.IsInRole("SuperAdmin") ||
                      context.User.HasClaim(claims => claims.Type == "EditUser")));
                option.AddPolicy("deleteUser", police => police.RequireAssertion(context =>
                   context.User.IsInRole("SuperAdmin") || context.User.HasClaim(claim => claim.Type == "DeleteUser")));

                option.AddPolicy("addManhale", police => police.RequireAssertion(context
                   => context.User.IsInRole("SuperAdmin") ||
                  context.User.HasClaim(claim => claim.Type == "AddManhale")));

                option.AddPolicy("editManhale", police => police.RequireAssertion(context =>
                      context.User.IsInRole("SuperAdmin") ||
                      context.User.HasClaim(claims => claims.Type == "EditManhale")));

                option.AddPolicy("deleteManhale", police => police.RequireAssertion(context =>
                   context.User.IsInRole("SuperAdmin") || context.User.HasClaim(claim => claim.Type == "DeleteManhale")));

                option.AddPolicy("addproduct", police => police.RequireAssertion(context
                   => context.User.IsInRole("SuperAdmin") ||
                  context.User.HasClaim(claim => claim.Type == "Addproduct")));

                option.AddPolicy("editProduct", police => police.RequireAssertion(context =>
                      context.User.IsInRole("SuperAdmin") ||
                      context.User.HasClaim(claims => claims.Type == "EditProduct")));

                option.AddPolicy("deleteProduct", police => police.RequireAssertion(context =>
                   context.User.IsInRole("SuperAdmin") || context.User.HasClaim(claim => claim.Type == "DeleteProduct")));
            });
           // services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddScoped(typeof(IGenaricRepository<>), typeof(GenaricRepository<>));
            services.AddScoped(typeof(ImanahelRepository), typeof(manahelRepository));
            services.AddScoped(typeof(IUsersManhalRepositry), typeof(UsersManhalRepositry));
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof( IUploadFile),typeof( UploadFile));
            services.ConfigureApplicationCookie(option => option.LoginPath = new PathString("/Account/LogIn"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
                endpoints.MapBlazorHub();
            });

            app.UseStaticFiles();
            //    new StaticFileOptions
            //{
            //    ServeUnknownFileTypes = true,
            //    DefaultContentType = "application/octet-stream"
            //});
        }
    }
}
