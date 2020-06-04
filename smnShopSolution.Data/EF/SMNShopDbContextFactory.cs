using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace smnShopSolution.Data.EF
{
    public class SMNShopDbContextFactory : IDesignTimeDbContextFactory<smnShopDbContext>
    {
        public smnShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("smnShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<smnShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new smnShopDbContext(optionsBuilder.Options);
        }
    }
}
