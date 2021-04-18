using DMess.Supervision.Desktop.HostBuilderExtensions;
using DMess.Supervision.Desktop.ViewModels;
using DMess.Supervision.Desktop.ViewModels.Windows;
using DMess.Supervision.Desktop.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace DMess.Supervision.Desktop
{
    public partial class App : Application
    {
        private static IHost _host;

        public static IHost Host => _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        private static IHostBuilder CreateHostBuilder(string[] args = null) => Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .AddConfiguration()
                .AddDataContext()
                .AddMapper()
                .AddServices()
                .AddViewModels();

        protected override async void OnStartup(StartupEventArgs e)
        {
            await Host.StartAsync().ConfigureAwait(false);

            Current.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(this.MainWindow, App.Host.Services.GetRequiredService<HeadViewModel>())
            };

            Current.MainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await Host.StopAsync();
            Host.Dispose();

            base.OnExit(e);
        }
    }
}
