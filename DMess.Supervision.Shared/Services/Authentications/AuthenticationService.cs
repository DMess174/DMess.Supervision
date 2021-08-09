using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Shared.Exceptions;
using DMess.Supervision.Shared.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Authentications
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher<Account> _passwordHasher;

        public AuthenticationService(IAccountRepository accountRepository, IPasswordHasher<Account> passwordHasher, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<AccountDTO> LoginAsync(string username, string password)
        {
            Account storedAccount = await _accountRepository.GetByUsernameAsync(username);

            if (storedAccount is null) 
                throw new UserNotFoundException(username);

            PasswordVerificationResult passwordResult = _passwordHasher.VerifyHashedPassword(storedAccount, storedAccount.PasswordHash, password);

            if (passwordResult != PasswordVerificationResult.Success)
                throw new InvalidPasswordException(username, password);

            return _mapper.Map<AccountDTO>(storedAccount);
        }

        public async Task<RegistrationResult> RegisterAsync(string username, string password, string confirmPassword, EmployeeDTO employee)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;
                return result;
            }

            Account usernameAccount = await _accountRepository.GetByUsernameAsync(username);
            if (usernameAccount != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
                return result;
            }

            if (result == RegistrationResult.Success)
            {
                Account account = new Account()
                {
                    Employee = _mapper.Map<Employee>(employee),
                    UserName = username,
                };

                string hashedPassword = _passwordHasher.HashPassword(account, password);
                account.PasswordHash = hashedPassword;

                await _accountRepository.CreateAsync(account);
            }

            return result;
        }
    }
}
