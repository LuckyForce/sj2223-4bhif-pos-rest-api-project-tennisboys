﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Spg.TennisBooking.Infrastructure;

namespace Spg.TennisBooking.Configurations
{
    public static class DatabaseConfigurations
    {
        public static void ConfigureSqLite(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TennisBookingContext>(options => 
            {
                if (!options.IsConfigured)
                {
                    options.UseSqlite(connectionString);
                }
            });
        }
    }
}