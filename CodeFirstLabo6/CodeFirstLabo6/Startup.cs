using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using CodeFirstLabo6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirstLabo6
{
    public class Startup
    {
        public IConfiguration configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
           // var connection=@" Server = (localdb)\MSSQLLocalDB; Initial Catalog =BDLAbO6;Trusted_Connection = True; ";
            services.AddDbContext<Labo6Context>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IClientRepository, ClientEFRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseStaticFiles();
                app.UseMvc(routes => { 
                routes.MapRoute(
                    name:"default",
                    template:"{ Controllers=Clients}/{action=Index}/{id?}");

                });
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
