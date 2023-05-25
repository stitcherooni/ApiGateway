using BLL.Extensions;
using BLL.Services;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APIGatewayMVC
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            string connectionString = _config.GetConnectionString("MariaDbServer");
            if (connectionString == null)
            {
                Console.WriteLine("ERROR: No connection string found in the config file");
            }

            services.AddDbContext<PtaeventContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.Parse("10.5.19-mariadb"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IOnboardingService, OnboardingService>();
            services.AddScoped<DbContext, PtaeventContext>();
            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "APIGatewayMVC", Version = "v1" });
            });
        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIGatewayMVC");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}