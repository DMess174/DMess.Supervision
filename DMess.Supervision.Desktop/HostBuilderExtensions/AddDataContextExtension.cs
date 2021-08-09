using DMess.Supervision.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DMess.Supervision.Desktop.HostBuilderExtensions
{
    public static class AddDataContextExtension
    {
        public static IHostBuilder AddDataContext(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("common-data");
                Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlServer(connectionString);

                services.AddDbContext<CommonDataContext>(configureDbContext);
                services.AddSingleton<CommonDataContextFactory>(new CommonDataContextFactory(configureDbContext));
            });

            return host;
        }
    }
}
