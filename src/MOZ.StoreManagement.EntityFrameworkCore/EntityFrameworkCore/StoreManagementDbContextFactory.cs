using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MOZ.StoreManagement.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StoreManagementDbContextFactory : IDesignTimeDbContextFactory<StoreManagementDbContext>
{
    public StoreManagementDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        StoreManagementEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<StoreManagementDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new StoreManagementDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MOZ.StoreManagement.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
