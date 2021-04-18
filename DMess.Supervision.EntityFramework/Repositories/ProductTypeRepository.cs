using DMess.Supervision.CommonModel.Models.Products;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.EntityFramework.Contexts;

namespace DMess.Supervision.EntityFramework.Repositories
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }
    }
}
