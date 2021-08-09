using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountDTO>();

            CreateMap<AccountDTO, Account>()
                .ForMember(x => x.PasswordHash, o => o.Ignore());
        }
    }
}
