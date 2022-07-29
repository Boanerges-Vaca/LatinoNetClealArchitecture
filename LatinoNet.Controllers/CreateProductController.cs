using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductoInputPort inputPort;
        readonly ICreateProductOutputPort outputPort;

        public CreateProductController(ICreateProductoInputPort inputPort, ICreateProductOutputPort outputPort)
        {
            this.inputPort = inputPort;
            this.outputPort = outputPort;
        }

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await inputPort.Handle(product);
            return ((IPresenter <ProductDTO>) outputPort).Content;
        }

    }
}
