using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher<Account> _passwordHasher;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository accountRepository, IMapper mapper, IPasswordHasher<Account> passwordHasher)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }

        public async Task<AccountDTO> LoadDataAsync(string id)
        {
            var result = await _accountRepository.GetByIdAsync(id);

            return _mapper.Map<AccountDTO>(result);
        }

        public async Task<AccountDTO> SaveDataAsync(AccountDTO entity)
        {
            var entityToUpdate = _mapper.Map<Account>(entity);

            if (string.IsNullOrWhiteSpace(entityToUpdate.Id))
                await _accountRepository.CreateAsync(entityToUpdate);
            else
                await _accountRepository.UpdateAsync(entityToUpdate);

            return _mapper.Map<AccountDTO>(entityToUpdate);
        }

        public async Task<bool> ResetPasswordAsync(string id, string oldPassword, string newPassword)
        {
            var account = await _accountRepository.GetByIdAsync(id);

            if(_passwordHasher.HashPassword(account, oldPassword) != account.PasswordHash)
            {
                return false;
            }

            account.PasswordHash = _passwordHasher.HashPassword(account, newPassword);

            await _accountRepository.UpdateAsync(account);
            
            return true;
        }
    }
}
