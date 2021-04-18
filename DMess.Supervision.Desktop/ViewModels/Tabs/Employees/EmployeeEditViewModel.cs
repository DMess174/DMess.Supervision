using System.Windows.Input;
using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Employees;

namespace DMess.Supervision.Desktop.ViewModels.Tabs.Employees
{
    public class EmployeeEditViewModel : TabViewModelBase, IEntityViewModel<EmployeeDTO>
    {
        private EmployeeDTO _item;
        public EmployeeDTO Item { get => _item; set => Set(ref _item, value); }

        private bool _isLoaded;
        public bool IsLoaded { get => _isLoaded; set => Set(ref _isLoaded, value); }

        public ICommand LoadDataCommand { get; init; }

        public EmployeeEditViewModel(IEmployeeService employeeService, string id = null)
        {
            ShortHeader = "Ред. персонала";
            Header = "Редактирование персонала";
            LoadDataCommand = new LoadEntityDataCommand<EmployeeDTO>(employeeService, this, id);
        }

        public static EmployeeEditViewModel LoadViewModel(IEmployeeService employeeService)
        {
            var vm = new EmployeeEditViewModel(employeeService);
            vm.LoadDataCommand.Execute(null);
            return vm;
        }
    }
}