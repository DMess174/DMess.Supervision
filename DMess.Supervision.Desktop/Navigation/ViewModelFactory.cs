using DMess.Supervision.Desktop.ViewModels;
using DMess.Supervision.Desktop.ViewModels.Base;
using System;

namespace DMess.Supervision.Desktop.Navigation
{
    public class ViewModelFactory : IViewModelFactory
    {
        //private readonly CreateViewModel<MainViewModel> _createMainViewModel;
        private readonly CreateViewModel<LoginViewModel> _createLoginViewModel;

        public ViewModelFactory(CreateViewModel<LoginViewModel> createLoginViewModel)
        {
            //_createMainViewModel = createMainViewModel;
            _createLoginViewModel = createLoginViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            return viewType switch
            {
                ViewType.Login => _createLoginViewModel(),
                //ViewType.Main => _createMainViewModel(),
                _ => throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType"),
            };
        }
    }
}
