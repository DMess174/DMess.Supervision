using DMess.Supervision.Desktop.State.Accounts;
using DMess.Supervision.Desktop.ViewModels.Base;

namespace DMess.Supervision.Desktop.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {

        private IAccountStore _accountStore;
        public IAccountStore AccountStore { get => _accountStore; set => Set(ref _accountStore, value); }

        public AccountViewModel(IAccountStore accountStore)
        {
            _accountStore = accountStore;
        }

    }
}
