namespace EquipoAleatorio
{
    using EquipoAleatorio.AccesoDatos.Context;
    using EquipoAleatorio.AccesoDatos.Interfaces;
    using EquipoAleatorio.AccesoDatos.Repositorio;
    using EquipoAleatorio.Negocio.Interfaces;
    using EquipoAleatorio.Negocio.Negocio;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        private const string CorsPolicy = "CorsPolicy";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(CorsPolicy, builder => builder
                .WithOrigins(Configuration?.GetSection("ConfigurationApplication:CorsPolicyOrigins").Value.Split('|'))
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            });

            services.AddDbContext<ApplicationDbContext>(option =>
            option.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"))
            .UseLazyLoadingProxies());
            services.AddControllers();
            AddDependencyInjection(services);
        }


        /// <summary>
        /// Se encarga de agregar la Inyeccion de Dependencias y Recursos.
        /// </summary>
        /// <param name="services"></param>
        public void AddDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IJugadorNegocio, JugadorNegocio>();
            services.AddTransient<IEquipoNegocio, EquipoNegocio>();
            services.AddTransient<IJugadorRepositorio, JugadorRepositorio>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(CorsPolicy);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
