
using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            services.AddScoped<IGetAllProductsOutputPort, GetAllProductPresenter>();
            
            return services;
        }
    }
}
