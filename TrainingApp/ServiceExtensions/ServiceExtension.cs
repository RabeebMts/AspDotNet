using Contracts;
using Entities.DBContext;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.ServiceExtensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPloicy", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                });
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }


        public static void ConfigureSqlContext(this IServiceCollection services,  IConfiguration Configuration)
        {
            services.AddDbContext<RepositoryContext>(opt=>opt.UseSqlServer(Configuration.GetConnectionString("sqlConnection"),
                opMig=> opMig.MigrationsAssembly("TrainingApp")));
        }
    }
}
