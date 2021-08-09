using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.Shared.Models.DTOs;
using System;
using System.Threading.Tasks;

namespace DMess.Supervision.Desktop.State.Authenticators
{
    public interface IAuthenticator
    {
        AccountDTO CurrentAccount { get; }
        bool IsLoggedIn { get; }
        FactoryDTO CurrentFactory { get; }

        event Action StateChanged;

        Task<RegistrationResult> Register(string username, string password, string confirmPassword, EmployeeDTO employee);

        Task Login(string username, string password);

        void Logout();
    }
}
