using System;
using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation;

namespace DMess.Supervision.Desktop.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
