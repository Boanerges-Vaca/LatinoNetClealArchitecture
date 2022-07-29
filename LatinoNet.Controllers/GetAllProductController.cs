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
    public class GetAllProductController
    {
        readonly IGetAllProductsInputPort inputPort;
        readonly IGetAllProductsInputPort outputPort;

        public GetAllProductController(IGetAllProductsInputPort inputPort, IGetAllProductsInputPort outputPort)
        {
            this.inputPort = inputPort;
            this.outputPort = outputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await inputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)outputPort).Content;
        }

    }
}
