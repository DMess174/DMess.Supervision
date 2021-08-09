using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.EntityFramework.Contexts;

namespace DMess.Supervision.EntityFramework.Repositories
{
    public class FactoryRepository : Repository<Factory>, IFactoryRepository
    {
        public FactoryRepository(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
