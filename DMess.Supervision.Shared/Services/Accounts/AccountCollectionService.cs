using AutoMapper;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Accounts
{
    public class AccountCollectionService : IAccountCollectionService
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;

        public AccountCollectionService(IMapper mapper, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<AccountDTO>> LoadDataAsync()
        {
            var result = await _accountRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<AccountDTO>>(result);
        }
    }
}
