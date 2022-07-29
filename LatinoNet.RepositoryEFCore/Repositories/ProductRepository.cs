using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class ProductRepository: IProductRepository
    {
        readonly LatinoNetContext Context;
        public ProductRepository(LatinoNetContext context)
            => Context = context;

        public void CreateProducto(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return Context.Products;
        }
    }
}
