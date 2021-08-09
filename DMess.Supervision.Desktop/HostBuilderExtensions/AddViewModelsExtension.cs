using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.ViewModels;
using DMess.Supervision.Desktop.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Desktop.State.Accounts;
using DMess.Supervision.Desktop.ViewModels.Tabs.Products;
using DMess.Supervision.Shared.Services.Products;
using DMess.Supervision.Desktop.ViewModels.Tabs.Employees;
using DMess.Supervision.Shared.Services.Employees;
using DMess.Supervision.Desktop.Navigation.History;

namespace DMess.Supervision.Desktop.HostBuilderExtensions
{
    public static class AddViewModelsExtension
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<HeadViewModel>();

                services.AddSingleton<CreateViewModel<LoginViewModel>>(services => () => CreateLoginViewModel(services));
                services.AddSingleton<CreateViewModel<AccountViewModel>>(services => () => CreateAccountViewModel(services));
                services.AddSingleton<CreateViewModel<MainViewModel>>(services => () => CreateMainViewModel(services));

                services.AddSingleton<CreateTabViewModel<ProductTypesViewModel>>(services => (args) => CreateProductTypesViewModel(services));
                services.AddSingleton<CreateTabViewModel<EmployeeCollectionViewModel>>(services => (args) => CreateEmployeeCollectionViewModel(services));
                services.AddSingleton<CreateTabViewModel<EmployeeEditViewModel>>(services => (args) => CreateEmployeeEditViewModel(services));

                services.AddSingleton<IViewModelFactory, ViewModelFactory>();
                services.AddSingleton<ITabViewModelFactory, TabViewModelFactory>();

                services.AddSingleton<ViewModelRenavigator<MainViewModel>>();
                services.AddSingleton<ViewModelRenavigator<LoginViewModel>>();
            });

            return host;
        }

        private static MainViewModel CreateMainViewModel(IServiceProvider services)
        {
            return new MainViewModel(
                services.GetRequiredService<IAccountStore>(),
                services.GetRequiredService<IAuthenticator>(),
                services.GetRequiredService<ViewModelRenavigator<LoginViewModel>>(),
                services.GetRequiredService<IProductTypeCollectionService>(),
                services.GetRequiredService<IEmployeeCollectionService>(),
                services.GetRequiredService<ITabViewModelFactory>());
        }

        private static LoginViewModel CreateLoginViewModel(IServiceProvider services)
        {
            return new LoginViewModel(
                services.GetRequiredService<IAuthenticator>(),
                services.GetRequiredService<ViewModelRenavigator<MainViewModel>>());
        }

        private static AccountViewModel CreateAccountViewModel(IServiceProvider services)
        {
            return new AccountViewModel(
                services.GetRequiredService<IAccountStore>());
        }

        private static ProductTypesViewModel CreateProductTypesViewModel(IServiceProvider services)
        {
            return ProductTypesViewModel.LoadViewModel(
                services.GetRequiredService<IProductTypeCollectionService>());
        }

        private static EmployeeCollectionViewModel CreateEmployeeCollectionViewModel(IServiceProvider services)
        {
            return EmployeeCollectionViewModel.LoadViewModel(
                services.GetRequiredService<IEmployeeCollectionService>());
        }

        private static EmployeeEditViewModel CreateEmployeeEditViewModel(IServiceProvider services)
        {
            return EmployeeEditViewModel.LoadViewModel(
                services.GetRequiredService<IEmployeeService>());
        }
    }
}