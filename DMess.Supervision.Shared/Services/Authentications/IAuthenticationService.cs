﻿using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Shared.Models.DTOs;
using System;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Authentications
{
    public interface IAuthenticationService
    {
        Task<RegistrationResult> RegisterAsync(string username, string password, string confirmPassword, EmployeeDTO employee);

        /// <summary>
        /// Get an account for a user's credentials.
        /// </summary>
        /// <param name="username">The user's name.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>The account for the user.</returns>
        /// <exception cref="UserNotFoundException">Thrown if the user does not exist.</exception>
        /// <exception cref="InvalidPasswordException">Thrown if the password is invalid.</exception>
        /// <exception cref="Exception">Thrown if the login fails.</exception>
        Task<AccountDTO> LoginAsync(string username, string password);
    }
}
