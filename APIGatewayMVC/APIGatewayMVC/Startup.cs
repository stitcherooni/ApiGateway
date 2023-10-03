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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.Logging;

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

            string DB_HOST_NAME = configuration["DB_HOST_NAME"];
            string DB_HOST_PORT = configuration["DB_HOST_PORT"];
            string DB_USER_NAME = configuration["DB_USER_NAME"];
            string DB_PASSWORD = configuration["DB_PASSWORD"];
            string DB_NAME = configuration["DB_NAME"];

            var connectionString = String.Format("data source={0};port={1};Database={2};uid={3};pwd={4};Allow User Variables=true",
                DB_HOST_NAME, DB_HOST_PORT, DB_NAME, DB_USER_NAME, DB_PASSWORD);

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
            var logger = serviceProvider.GetService<ILogger<OnboardingController>>();
            services.AddSingleton(typeof(ILogger<OnboardingController>), logger);
            services.Configure<BlobSettings>(configuration.GetSection("BlobSettings"));

            services.AddAutoMapper();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddMicrosoftIdentityWebApi(options =>
            {
                configuration.Bind("AzureAdB2C", options);

                options.TokenValidationParameters.NameClaimType = "name";
            },
    options => { configuration.Bind("AzureAdB2C", options); });

            services.AddAuthorization(options =>
            {
                // Define policies here based on your application's requirements

                options.AddPolicy("RequireAdminRole", policy =>
                {
                    policy.RequireRole("Admin"); // Only users in the "Admin" role can access
                });

                options.AddPolicy("RequireReadScope", policy =>
                {
                    policy.RequireClaim("scope", "user.read"); // Users with the "user.read" claim can access
                });

                // Add more policies as needed for your application
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "APIGatewayMVC", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
        });
            });

            services.AddLogging(builder =>
            {
                builder.AddAzureWebAppDiagnostics();
                builder.AddApplicationInsights(_config["ApplicationInsights:InstrumentationKey"]);
            });
        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                IdentityModelEventSource.ShowPII = true;
            }
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

            app.UseAuthentication();

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}