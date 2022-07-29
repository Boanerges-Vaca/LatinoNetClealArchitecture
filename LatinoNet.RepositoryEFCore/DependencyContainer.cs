using LatinoNet.Entities.Interfaces;
using LatinoNet.RepositoryEFCore.DataContext;
using LatinoNet.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<LatinoNetContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LatinoNet")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
