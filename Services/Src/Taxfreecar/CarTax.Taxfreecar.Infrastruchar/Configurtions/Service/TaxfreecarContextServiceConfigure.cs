﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CarTax.Taxfreecar.Infrastruchar.Configurtions.Service
{
    public static class TaxfreecarContextServiceConfigure
    {

        public static IServiceCollection DBContextServesiesConfigure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<TaxfreecarDBContext>(
                option =>
                {
                    option.UseSqlServer(configuration.GetConnectionString("CarType_ConnectionsStrings"),
                        settings => settings.EnableRetryOnFailure().CommandTimeout(60));
                   option.EnableSensitiveDataLogging();
                }
            );

            return services;
        }

    }
}
