using DMess.Supervision.Shared.Models;

namespace DMess.Supervision.Desktop.ViewModels.Base
{
    public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModelBase;

    public class ViewModelBase : ObservableObject
    {
        public virtual void Dispose() { }
    }
}