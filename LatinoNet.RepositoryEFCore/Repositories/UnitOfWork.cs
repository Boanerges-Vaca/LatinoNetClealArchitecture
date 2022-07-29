using LatinoNet.Entities.Interfaces;
using LatinoNet.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly LatinoNetContext Context;

        public UnitOfWork(LatinoNetContext context)
        {
            Context = context;
        }

        public Task<int> SaveChanges()
        {
            return Context.SaveChangesAsync();  
        }
    }
}
