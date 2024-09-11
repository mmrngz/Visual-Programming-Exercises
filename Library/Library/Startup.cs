using FluentValidation.AspNetCore;
using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Concrete;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;,
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library
{

    public class Startup
    {
        readonly IConfiguration _config;
        public Startup(IConfiguration configuration) 
        {
            _config = configuration;
        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(_config.GetSection("ConnectionStrings:Mssql").Value));
            services.AddControllersWithViews().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());  //Fluent Validation
            services.AddScoped<IRepository<BookType>, Repository<BookType>>();
            services.AddScoped<IBookTypeRepository, BookTypeRepository>();  
            services.AddScoped<IRepository<AppUser>, Repository<AppUser>>();    
            //services.AddScoped<IRepository<Author>, Repository<Author>>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(op=>
            {
                op.LoginPath = "/Auth/Login";
                op.AccessDeniedPath = "/Auth/Login";  
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("role", "admin"));
                options.AddPolicy("UserPolicy", policy => policy.RequireClaim("role", "admin", "user"));
            });
        ;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,MyDbContext myDbContext)
        {
            myDbContext.Database.Migrate(); 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
             (
                 name: "DefaultArea",
                 pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
             );

                endpoints.MapControllerRoute
                (
                    name:"Default",
                    pattern:"{controller=Auth}/{action=Login}/{id?}"
                );
              

            });
        }
    }
}
