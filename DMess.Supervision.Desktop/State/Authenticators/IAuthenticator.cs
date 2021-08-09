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

        /// <summary>
        /// Login to the application.
        /// </summary>
        /// <param name="username">The user's name.</param>
        /// <param name="password">The user's password.</param>
        /// <exception cref="UserNotFoundException">Thrown if the user does not exist.</exception>
        /// <exception cref="InvalidPasswordException">Thrown if the password is invalid.</exception>
        /// <exception cref="Exception">Thrown if the login fails.</exception>
        Task Login(string username, string password);

        void Logout();
    }
}
