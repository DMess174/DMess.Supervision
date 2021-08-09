using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.State.Accounts;
using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Employees;
using DMess.Supervision.Shared.Services.Products;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IAccountStore _accountStore;
        public IAccountStore AccountStore { get => _accountStore; set => Set(ref _accountStore, value); }

        public TabItemsViewModel TabsViewModel { get; }

        public IList<TabViewModelBase> Tabs => TabsViewModel.Tabs;

        public TabViewModelBase CurrentTab
        {
            get => TabsViewModel.CurrentTab;
            set
            {
                TabsViewModel.CurrentTab = value;
                OnPropertyChanged();
            }
        }

        public ICollection<ProductTypeDTO> ProductTypes => _accountStore.CurrentFactory.ProductTypes ??= new ObservableCollection<ProductTypeDTO>();

        public ICommand LogoutCommand { get; init; }
        
        public MainViewModel(IAccountStore accountStore, IAuthenticator authenticator, IViewModelRenavigator renavigator,
            IProductTypeCollectionService productTypeCollectionService,
            IEmployeeCollectionService employeeCollectionService, ITabViewModelFactory tabViewModelFactory)
        {
            AccountStore = accountStore;

            LogoutCommand = new LogoutCommand(authenticator, renavigator);
            
            TabsViewModel = new TabItemsViewModel(productTypeCollectionService, employeeCollectionService, tabViewModelFactory);
        }
    }
}