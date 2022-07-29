using LatinoNet.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProducto(Product product);
        IEnumerable<Product> GetAll();
    }
}
