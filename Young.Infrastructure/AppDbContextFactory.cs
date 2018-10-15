using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Young.Infrastructure
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            /*
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("Default");
            builder.UseNpgsql(connectionString);
            */

            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=young;Pooling=true;");
            return new AppDbContext(builder.Options);
        }
    }
}
