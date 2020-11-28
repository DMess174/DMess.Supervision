using DMess.Supervision.Desktop.ViewModels.Base;

namespace DMess.Supervision.Desktop.Navigation
{
    public interface IViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
