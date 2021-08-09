using DMess.Supervision.Shared.Models.DTOs;
using System;

namespace DMess.Supervision.Desktop.State.Accounts
{
    public class AccountStore : IAccountStore
    {
        private AccountDTO _currentAccount;
        public AccountDTO CurrentAccount
        {
            get
            {
                return _currentAccount;
            }
            set
            {
                _currentAccount = value;
                StateChanged?.Invoke();
            }
        }

        public bool IsLoggedIn => _currentAccount.IsLoggedIn;

        private FactoryDTO _currentFactory;
        public FactoryDTO CurrentFactory
        {
            get
            {
                return _currentFactory;
            }
            set
            {
                _currentFactory = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}
