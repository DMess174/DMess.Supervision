using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation.History;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Accounts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels.Tabs.Accounts
{
    public class AccountCollectionViewModel : TabViewModelBase, ICollectionViewModel<AccountDTO>
    {
        private readonly IAccountCollectionService _accountService;

        private IEnumerable<AccountDTO> _accounts = new ObservableCollection<AccountDTO>();
        public IEnumerable<AccountDTO> Items { get => _accounts; set => Set(ref _accounts, value); }

        private bool _isLoaded;
        public bool IsLoaded { get => _isLoaded; set => Set(ref _isLoaded, value); }

        public ICommand LoadDataCommand { get; init; }

        public AccountCollectionViewModel(IAccountCollectionService accountService)
        {
            Header = "Accounts";
            _accountService = accountService;
            LoadDataCommand = new LoadCollectionDataCommand<AccountDTO>(_accountService, this);
        }

        public static AccountCollectionViewModel LoadViewModel(IAccountCollectionService accountService)
        {
            var vm = new AccountCollectionViewModel(accountService);
            vm.LoadDataCommand.Execute(null);
            return vm;
        }
    }
}
