using Microsoft.Extensions.DependencyInjection;

namespace DMess.Supervision.Desktop.ViewModels
{
    public class ViewModelLocator
    {
        public HeadViewModel MainViewModel => App.Host.Services.GetRequiredService<HeadViewModel>();
    }
}
