using DMess.Supervision.Desktop.ViewModels.Base;

namespace DMess.Supervision.Desktop.Navigation
{
    public class ViewModelRenavigator<TViewModel> : IViewModelRenavigator where TViewModel : ViewModelBase
    {
        private readonly IViewModelNavigator _navigator;
        private readonly CreateViewModel<TViewModel> _createViewModel;

        public ViewModelRenavigator(IViewModelNavigator navigator, CreateViewModel<TViewModel> createViewModel)
        {
            _navigator = navigator;
            _createViewModel = createViewModel;
        }

        public void Renavigate()
        {
            _navigator.CurrentViewModel = _createViewModel();
        }
    }
}
