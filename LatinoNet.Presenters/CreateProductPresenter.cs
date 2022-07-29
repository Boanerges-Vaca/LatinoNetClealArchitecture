
using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public class CreateProductPresenter :
        ICreateProductOutputPort, IPresenter< ProductDTO>

    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO products)
        {
            Content = products;
            return Task.CompletedTask;
        }

        public Task Handle(CreateProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
