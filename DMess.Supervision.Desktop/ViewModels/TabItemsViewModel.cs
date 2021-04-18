using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.Navigation.History;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Desktop.ViewModels.Tabs.Employees;
using DMess.Supervision.Desktop.ViewModels.Tabs.Products;
using DMess.Supervision.Shared.Services.Employees;
using DMess.Supervision.Shared.Services.Products;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels
{
    public class TabItemsViewModel : ViewModelBase
    {
        private IList<TabViewModelBase> _tabs = new ObservableCollection<TabViewModelBase>();
        public IList<TabViewModelBase> Tabs { get => _tabs; set => Set(ref _tabs, value); }

        private TabViewModelBase _currentTab;
        public TabViewModelBase CurrentTab { get => _currentTab; set => Set(ref _currentTab, value); }

        public ICommand OpenTabCommand { get; init; }
        public ICommand CloseTabCommand { get; init; }

        public TabItemsViewModel(IProductTypeCollectionService productTypeCollectionService, IEmployeeCollectionService employeeCollectionService, ITabViewModelFactory tabViewModelFactory)
        {
            OpenTabCommand = new OpenTabCommand(tabViewModelFactory, this);
            CloseTabCommand = new CloseTabCommand(this);
            //var vm = ProductTypesViewModel.LoadViewModel(productTypeCollectionService);
            //var vm1 = ProductTypesViewModel.LoadViewModel(productTypeCollectionService);
            var vm2 = EmployeeCollectionViewModel.LoadViewModel(employeeCollectionService);
            var vm3 = EmployeeCollectionViewModel.LoadViewModel(employeeCollectionService);

            //Tabs.Add(vm);
            //Tabs.Add(vm1);
            Tabs.Add(vm2);
            Tabs.Add(vm3);

            CurrentTab = Tabs.FirstOrDefault();
        }
    }
}
