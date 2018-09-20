using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RestauranteApi.DAL.Context
{
    public class ApplicationDbContextFactory
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            builder.UseSqlServer(configuration.GetConnectionString("DB"));
            return new ApplicationDbContext(builder.Options);
        }
    }
}
