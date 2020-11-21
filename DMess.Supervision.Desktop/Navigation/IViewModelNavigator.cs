using DMess.Supervision.Desktop.ViewModels;
using System;

namespace DMess.Supervision.Desktop.Navigation
{
    public interface IViewModelNavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        event Action StateChanged;
    }
}
