using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.ModelAPI;
using System.Threading.Tasks;

namespace DMess.Supervision.CommonModel.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> GetByUsernameAsync(string username);
    }
}
