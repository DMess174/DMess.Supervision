using DMess.Supervision.Desktop.Navigation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Desktop.State.Accounts;
using Microsoft.AspNetCore.Identity;
using DMess.Supervision.Shared.Services.Authentications;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.EntityFramework.Repositories.Accounts;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.EntityFramework.Repositories;
using DMess.Supervision.Shared.Services.Products;
using DMess.Supervision.Shared.Services.Employees;
using DMess.Supervision.Desktop.Navigation.History;

namespace DMess.Supervision.Desktop.HostBuilderExtensions
{
    public static class AddServicesExtension
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<IPasswordHasher<Account>, PasswordHasher<Account>>();
                services.AddSingleton<IViewModelNavigator, ViewModelNavigator>();
                services.AddSingleton<IAccountRepository, AccountRepository>();
                services.AddSingleton<IProductTypeRepository, ProductTypeRepository>();
                services.AddSingleton<IEmployeeRepository, EmployeeRepository>();

                services.AddSingleton<IAuthenticationService, AuthenticationService>();
                services.AddSingleton<IProductTypeCollectionService, ProductTypeCollectionService>();
                services.AddSingleton<IEmployeeCollectionService, EmployeeCollectionService>();
                services.AddSingleton<IProductTypeService, ProductTypeService>();
                services.AddSingleton<IAuthenticator, Authenticator>();
                services.AddSingleton<IAccountStore, AccountStore>();

                services.AddTransient<ITabItemHistory, TabItemHistory>();
            });

            return host;
        }
    }
}
