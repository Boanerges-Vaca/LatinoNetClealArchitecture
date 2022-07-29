﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.DataContext
{
    public class LatinoNetContextFactory :
        IDesignTimeDbContextFactory<LatinoNetContext>
    {
        public LatinoNetContext CreateDbContext(string[] args)
        {
            var OptionsBuilder =
                new DbContextOptionsBuilder<LatinoNetContext>();
            OptionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;database=LatinoNet");
            return new LatinoNetContext(OptionsBuilder.Options);
        }
    }
}
