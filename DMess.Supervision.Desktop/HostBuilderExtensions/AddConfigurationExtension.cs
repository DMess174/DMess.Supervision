using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace DMess.Supervision.Desktop.HostBuilderExtensions
{
    public static class AddConfigurationExtension
    {
        public static IHostBuilder AddConfiguration(this IHostBuilder host)
        {
            host.ConfigureAppConfiguration(c =>
            {
                c.AddJsonFile("appsettings.json");
                c.AddEnvironmentVariables();
            });

            return host;
        }
    }
}
