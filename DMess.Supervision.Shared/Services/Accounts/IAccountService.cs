using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Base;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Accounts
{
    public interface IAccountService : ILoadEntityService<AccountDTO>, ISaveDataService<AccountDTO>
    {
        Task<bool> ResetPasswordAsync(string id, string oldPassword, string newPassword);
    }
}
