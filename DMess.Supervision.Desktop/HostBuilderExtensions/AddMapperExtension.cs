using AutoMapper;
using DMess.Supervision.Shared.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace DMess.Supervision.Desktop.HostBuilderExtensions
{
    public static class AddMapperExtension
    {
        public static IHostBuilder AddMapper(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddAutoMapper(Assembly.GetAssembly(typeof(ValidatableObject)));
            });

            return host;
        }
    }
}