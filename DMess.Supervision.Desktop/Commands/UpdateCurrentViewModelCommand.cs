using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation;

namespace DMess.Supervision.Desktop.Commands
{
    public class UpdateCurrentViewModelCommand : CommandBase
    {
        private readonly IViewModelNavigator _navigator;
        private readonly IViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(IViewModelNavigator navigator, IViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (parameter is ViewType viewType)
            {
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }
    }
}
