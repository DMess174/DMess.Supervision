using System.Threading.Tasks;
using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.ViewModels.Tabs.Employees;

namespace DMess.Supervision.Desktop.Commands
{
    public class EditEntityCommand : AsyncCommand
    {
        private readonly NavigationService<EmployeeEditViewModel> _navigationService;

        public EditEntityCommand(NavigationService<EmployeeEditViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
