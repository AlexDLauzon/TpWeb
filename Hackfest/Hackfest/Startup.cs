using Hackfest.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hackfest
{
    public class Startup
    {

        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // ou ["Data:BonAnniversaireToto:ConnectionString"])); dans appsettings.json
            //var connexion = "Data Source=MBEAUREG-15159;Init Catalog=Anniversaire_v2;Integrated Security=True;Pooling=False";
            services.AddDbContext<ContexteBD>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-2.1
            services.AddMvc();

            // Pour accélérer l'application (généralement efficace)
            // https://docs.microsoft.com/en-us/aspnet/core/performance/caching/memory?view=aspnetcore-2.1
            services.AddMemoryCache();

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-2.1
            services.AddSession();

            //services.AddTransient<IDépôt, Dépôt>();
            services.AddTransient<IDépôt, DépôtBD>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Gestion des erreurs
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-2.1
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();

            // Pour les fichiers de wwwroot
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-2.1
            app.UseStaticFiles();

            // Pour passer des valeurs d'une page à l'autre
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-2.1
            app.UseSession();

            // Routage de base
            // https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-2.1
            app.UseMvcWithDefaultRoute();
        }
    }
}


