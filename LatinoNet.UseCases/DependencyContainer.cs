using LatinoNet.UseCases.CreateProduct;
using LatinoNet.UseCases.GetAllProducts;
using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<ICreateProductoInputPort,
                CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort,
                GetAllProductsInteractor>();
            return services;
        }
    }
}
