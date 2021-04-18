using DMess.Supervision.Desktop.State.Accounts;
using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Authentications;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DMess.Supervision.Desktop.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IAccountStore _accountStore;

        public Authenticator(IAuthenticationService authenticationService, IAccountStore accountStore)
        {
            _authenticationService = authenticationService;
            _accountStore = accountStore;
        }

        public AccountDTO CurrentAccount
        {
            get
            {
                return _accountStore.CurrentAccount;
            }
            private set
            {
                _accountStore.CurrentAccount = value;
                StateChanged?.Invoke();
            }
        }

        public FactoryDTO CurrentFactory
        {
            get
            {
                return _accountStore.CurrentFactory;
            }
            private set
            {
                _accountStore.CurrentFactory = value;
                StateChanged?.Invoke();
            }
        }

        public bool IsLoggedIn => CurrentAccount != null;

        public event Action StateChanged;

        public async Task Login(string username, string password)
        {
            CurrentAccount = await _authenticationService.LoginAsync(username, password);
            CurrentFactory = CurrentAccount.Employee.Factories.FirstOrDefault();
        }

        public void Logout()
        {
            CurrentFactory = null;
            CurrentAccount = null;
        }

        public async Task<RegistrationResult> Register(string username, string password, string confirmPassword, EmployeeDTO employee)
        {
            return await _authenticationService.RegisterAsync(username, password, confirmPassword, employee);
        }
    }
}
