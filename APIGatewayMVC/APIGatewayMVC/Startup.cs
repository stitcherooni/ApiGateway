using BLL.Extensions;
using BLL.Services.BlobService;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using BLL.Services.Statistic;
using BLL.Services.SearchingService;
using DAL;
using DAL.Repository.DBRepository;
using DAL.Repository.EmailSender;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using System;
using BLL.DTO;
using APIGatewayMVC.Controllers;
using BLL.Services.SortingService;
using BLL.Services.UpdateService;

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
            IConfiguration configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            services.AddControllers();

            string connectionString = _config.GetConnectionString("MariaDbServer");
            if (connectionString == null)
            {
                Console.WriteLine("ERROR: No connection string found in the config file");
            }

                services.AddDbContext<PtaeventContext>(options =>
                {
                    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                });

            services.AddScoped<IOnboardingService, OnboardingService>();
            services.AddScoped<ISearchingService, SearchingService>();
            services.AddScoped<IBlobService, BlobService>();
            services.AddScoped<DbContext, PtaeventContext>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IEmailSender, MailGunEmailSender>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddScoped<IDashboardStatisticService, DashboardStatisticService>();
            services.AddScoped<ISortingService, SortingService>();
            services.AddScoped<IUpdateService, UpdateService>();

            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<OnbordingController>>();
            services.AddSingleton(typeof(ILogger<OnbordingController>), logger);
            services.Configure<BlobSettings>(configuration.GetSection("BlobSettings"));

            services.AddAutoMapper();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "APIGatewayMVC", Version = "v1" });
            });

            services.AddLogging(builder =>
            {
                builder.AddAzureWebAppDiagnostics();
                builder.AddApplicationInsights(_config["ApplicationInsights:InstrumentationKey"]);
            });
        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsProduction())
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