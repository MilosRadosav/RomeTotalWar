using Factions.Application.Contracts.Persistence;
using Factions.Persistence.DataBaseContext;
using Factions.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factions.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FactionDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FactionsConnString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IFactionsRepository, FactionRepository>();
            return services;
        }
    }
}
