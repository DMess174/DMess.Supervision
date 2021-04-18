using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DMess.Supervision.EntityFramework.Repositories.Accounts
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(CommonDataContextFactory contextFactory) : base(contextFactory) { }

        public async Task<Account> GetByUsernameAsync(string username)
        {
            await using var context = _contextFactory.CreateDbContext();
            return await context.Accounts
                .Include(e => e.Employee)
                .ThenInclude(f => f.Factories)
                .ThenInclude(p => p.ProductTypes)
                .FirstOrDefaultAsync(a => a.UserName == username);
        }
    }
}
