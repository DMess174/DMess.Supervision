using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation.History;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Employees;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels.Tabs.Employees
{
    public class EmployeeCollectionViewModel : TabViewModelBase, ICollectionViewModel<EmployeeDTO>
    {
        private readonly IEmployeeCollectionService _employeeService;
        private IEnumerable<EmployeeDTO> _items = new ObservableCollection<EmployeeDTO>();
        public IEnumerable<EmployeeDTO> Items { get => _items; set => Set(ref _items, value); }

        private bool _isLoaded;
        public bool IsLoaded { get => _isLoaded; set => Set(ref _isLoaded, value); }
        public ICommand LoadDataCommand { get; init; }
        public ICommand EditEmployeeCommand { get; init; }

        public EmployeeCollectionViewModel(IEmployeeCollectionService employeeService)
        {
            ShortHeader = "Персонал";
            Header = "Список персонала";
            _employeeService = employeeService;
            LoadDataCommand = new LoadCollectionDataCommand<EmployeeDTO>(_employeeService, this);
        }

        public static EmployeeCollectionViewModel LoadViewModel(IEmployeeCollectionService employeeService)
        {
            var vm = new EmployeeCollectionViewModel(employeeService);
            vm.LoadDataCommand.Execute(null);
            return vm;
        }
    }
}
