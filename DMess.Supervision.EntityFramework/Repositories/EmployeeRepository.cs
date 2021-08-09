using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DMess.Supervision.EntityFramework.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CommonDataContextFactory contextFactory) : base(contextFactory){}

        public override async Task<IEnumerable<Employee>> GetAllAsync(CancellationToken cancel = default)
        {
            await using var context =_contextFactory.CreateDbContext();
            return await context.Employees
                .Include(x => x.Post)
                .Include(x => x.Department)
                .ThenInclude(x => x.Department)
                .ToListAsync(cancellationToken: cancel);
        }

        public override Employee GetById(string id)
        {
            using var context = _contextFactory.CreateDbContext();
            return context.Employees
                .Include(d => d.Department)
                    .ThenInclude(d => d.Department)
                .Include(p => p.Post)
                .Include(f => f.Factories)
                .SingleOrDefault(e => e.Id == id);
        }

        public override async Task<Employee> GetByIdAsync(string id, CancellationToken cancel = default)
        {
            await using var context = _contextFactory.CreateDbContext();
            return await context.Employees
                .Include(d => d.Department)
                    .ThenInclude(d => d.Department)
                .Include(p => p.Post)
                .Include(f => f.Factories)
                .SingleOrDefaultAsync(e => e.Id == id);
        }
    }
}
