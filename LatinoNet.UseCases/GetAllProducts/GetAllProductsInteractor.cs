using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetAllProductsOutputPort OutpuPort;

        public GetAllProductsInteractor(IProductRepository Repository, IGetAllProductsOutputPort OutpuPort)
        {
            this.Repository = Repository;
            this.OutpuPort = OutpuPort;
        }

        public Task Handle()
        {
            var Products = Repository.GetAll().Select(p =>
            new ProductDTO
            {
                Id = p.Id,
                Name = p.Name
            });
            OutpuPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
