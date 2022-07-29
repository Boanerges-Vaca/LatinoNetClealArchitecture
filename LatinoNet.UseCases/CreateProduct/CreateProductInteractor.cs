using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductoInputPort
    {
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateProductOutputPort OutpuPort;

        public CreateProductInteractor(
            IProductRepository repository,
            IUnitOfWork unitOfWork,
            ICreateProductOutputPort outpuPort) =>
            (Repository, UnitOfWork, OutpuPort) =
            (repository, unitOfWork, outpuPort);


        public async Task Handle(CreateProductDTO product)
        {
            // Podriamos utilizar AutoMapper
            Product newProduct = new Product
            {
                Name = product.ProductName
            };
            Repository.CreateProducto(newProduct);
            await UnitOfWork.SaveChanges();
            await OutpuPort.Handle(new ProductDTO
            {
                Id = newProduct.Id,
                Name = newProduct.Name
            });
        }
    }
}
